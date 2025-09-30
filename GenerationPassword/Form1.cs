using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GenerationPassword
{
    public partial class Form1 : Form
    {
        private static readonly RandomNumberGenerator Rng = RandomNumberGenerator.Create();

        private readonly char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private readonly char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private readonly char[] digits = "0123456789".ToCharArray();
        private readonly char[] allChars;

        public Form1()
        {
            InitializeComponent();

            // собрать набор символов 
            var list = new StringBuilder();
            list.Append(lower);
            list.Append(upper);
            list.Append(digits);
            allChars = list.ToString().ToCharArray();
        }

        private void BtnGeneration_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword(12); // длина по умолчанию 12
            textBox.Text = password;
        }

        private string GeneratePassword(int length)
        {
            if (length < 3)
                throw new ArgumentException("Длина должна быть не меньше 3");

            char[] result = new char[length];

            // гарантируем хотя бы по одному символу из каждой группы
            result[0] = PickRandom(lower);
            result[1] = PickRandom(upper);
            result[2] = PickRandom(digits);

            for (int i = 3; i < length; i++)
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

        // Реализация RandomNumberGenerator.GetInt32 для .NET Framework
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
    }
}
