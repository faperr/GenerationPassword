using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GenerationPassword
{
    public partial class Form1 : Form
    {
        private static readonly RandomNumberGenerator Rng = RandomNumberGenerator.Create();

        private readonly char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private readonly char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private readonly char[] digits = "0123456789".ToCharArray();
        private readonly char[] special = "!@#$%".ToCharArray();

        public Form1()
        {
            InitializeComponent();

            // Чекбоксы по умолчанию
            checkBoxLower.Checked = true;
            checkBoxUpper.Checked = true;
            checkBoxDigits.Checked = true;
            checkBoxSpecial.Checked = false;

            // Настройки NumericUpDown
            numericUpDownLength.Minimum = 6;
            numericUpDownLength.Maximum = 32;
            numericUpDownLength.Value = 12;
            numericUpDownLength.Increment = 1;

            // Центрирование формы
            this.StartPosition = FormStartPosition.CenterScreen;

            // Подписка на автоматическую генерацию при изменении длины
            numericUpDownLength.ValueChanged += numericUpDownLength_ValueChanged;
        }

        private void BtnGeneration_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayPassword();
        }

        private void numericUpDownLength_ValueChanged(object sender, EventArgs e)
        {
            // Генерируем пароль автоматически при изменении длины
            GenerateAndDisplayPassword();
        }

        private void GenerateAndDisplayPassword()
        {
            BtnGeneration.BackColor = Color.LightGreen;

            try
            {
                int length = (int)numericUpDownLength.Value;
                string password = GeneratePassword(length);
                textBox.Text = password;

                UpdatePasswordStrength(password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Timer t = new Timer();
            t.Interval = 200;
            t.Tick += (s, ev) =>
            {
                BtnGeneration.BackColor = SystemColors.Control;
                t.Stop();
                t.Dispose();
            };
            t.Start();
        }

        private string GeneratePassword(int length)
        {
            var selectedGroups = new List<char[]>();
            if (checkBoxLower.Checked) selectedGroups.Add(lower);
            if (checkBoxUpper.Checked) selectedGroups.Add(upper);
            if (checkBoxDigits.Checked) selectedGroups.Add(digits);
            if (checkBoxSpecial.Checked) selectedGroups.Add(special);

            if (selectedGroups.Count == 0)
                throw new InvalidOperationException("Нужно выбрать хотя бы один тип символов.");

            if (length < selectedGroups.Count)
                throw new ArgumentException($"Длина должна быть не меньше {selectedGroups.Count}");

            var allChars = selectedGroups.SelectMany(g => g).ToArray();
            char[] result = new char[length];

            for (int i = 0; i < selectedGroups.Count; i++)
                result[i] = PickRandom(selectedGroups[i]);

            for (int i = selectedGroups.Count; i < length; i++)
                result[i] = PickRandom(allChars);

            Shuffle(result);

            return new string(result);
        }

        private char PickRandom(char[] arr)
        {
            int idx = GetRandomInt(0, arr.Length);
            return arr[idx];
        }

        private void Shuffle(char[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = GetRandomInt(0, i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        private int GetRandomInt(int minInclusive, int maxExclusive)
        {
            if (minInclusive >= maxExclusive)
                throw new ArgumentOutOfRangeException();

            uint range = (uint)(maxExclusive - minInclusive);
            uint limit = uint.MaxValue - (uint.MaxValue % range);

            byte[] buffer = new byte[4];
            while (true)
            {
                Rng.GetBytes(buffer);
                uint rand = BitConverter.ToUInt32(buffer, 0);
                if (rand < limit)
                    return (int)(minInclusive + (rand % range));
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                Clipboard.SetText(textBox.Text);

                labelMessage.Text = "Пароль скопирован!";
                labelMessage.Visible = true;

                Timer t = new Timer();
                t.Interval = 2000;
                t.Tick += (s, ev) =>
                {
                    labelMessage.Visible = false;
                    t.Stop();
                    t.Dispose();
                };
                t.Start();
            }
        }

        private void UpdatePasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                labelStrength.Text = "";
                return;
            }

            int types = 0;
            if (password.Any(char.IsLower)) types++;
            if (password.Any(char.IsUpper)) types++;
            if (password.Any(char.IsDigit)) types++;
            if (password.Any(c => "!@#$%".Contains(c))) types++;

            if (password.Length < 6 || types < 2)
            {
                labelStrength.Text = "Слабый";
                labelStrength.ForeColor = Color.Red;
            }
            else if (password.Length < 10 || types < 3)
            {
                labelStrength.Text = "Средний";
                labelStrength.ForeColor = Color.Orange;
            }
            else
            {
                labelStrength.Text = "Надежный";
                labelStrength.ForeColor = Color.Green;
            }
        }

        // Заглушки для чекбоксов
        private void checkBoxUpper_CheckedChanged(object sender, EventArgs e) { }
        private void checkBoxLower_CheckedChanged(object sender, EventArgs e) { }
        private void checkBoxDigits_CheckedChanged(object sender, EventArgs e) { }
        private void checkBoxSpecial_CheckedChanged(object sender, EventArgs e) { }
    }
}
