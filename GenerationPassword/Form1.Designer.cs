namespace GenerationPassword
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.BtnGeneration = new System.Windows.Forms.Button();
            this.checkBoxUpper = new System.Windows.Forms.CheckBox();
            this.checkBoxLower = new System.Windows.Forms.CheckBox();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(250, 250);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(250, 31);
            this.textBox.TabIndex = 0;
            // 
            // BtnGeneration
            // 
            this.BtnGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGeneration.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGeneration.Location = new System.Drawing.Point(274, 313);
            this.BtnGeneration.Name = "BtnGeneration";
            this.BtnGeneration.Size = new System.Drawing.Size(190, 35);
            this.BtnGeneration.TabIndex = 1;
            this.BtnGeneration.Text = "Сгенерировать";
            this.BtnGeneration.UseVisualStyleBackColor = true;
            this.BtnGeneration.Click += new System.EventHandler(this.BtnGeneration_Click);
            // 
            // checkBoxUpper
            // 
            this.checkBoxUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUpper.AutoSize = true;
            this.checkBoxUpper.Font = new System.Drawing.Font("Consolas", 12F);
            this.checkBoxUpper.Location = new System.Drawing.Point(70, 367);
            this.checkBoxUpper.Name = "checkBoxUpper";
            this.checkBoxUpper.Size = new System.Drawing.Size(131, 27);
            this.checkBoxUpper.TabIndex = 2;
            this.checkBoxUpper.Text = "Заглавные";
            this.checkBoxUpper.UseVisualStyleBackColor = true;
            this.checkBoxUpper.CheckedChanged += new System.EventHandler(this.checkBoxUpper_CheckedChanged);
            // 
            // checkBoxLower
            // 
            this.checkBoxLower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLower.AutoSize = true;
            this.checkBoxLower.Font = new System.Drawing.Font("Consolas", 12F);
            this.checkBoxLower.Location = new System.Drawing.Point(70, 400);
            this.checkBoxLower.Name = "checkBoxLower";
            this.checkBoxLower.Size = new System.Drawing.Size(186, 27);
            this.checkBoxLower.TabIndex = 3;
            this.checkBoxLower.Text = "Строчные буквы";
            this.checkBoxLower.UseVisualStyleBackColor = true;
            this.checkBoxLower.CheckedChanged += new System.EventHandler(this.checkBoxLower_CheckedChanged);
            // 
            // checkBoxDigits
            // 
            this.checkBoxDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Font = new System.Drawing.Font("Consolas", 12F);
            this.checkBoxDigits.Location = new System.Drawing.Point(70, 433);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(87, 27);
            this.checkBoxDigits.TabIndex = 4;
            this.checkBoxDigits.Text = "Цифры";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            this.checkBoxDigits.CheckedChanged += new System.EventHandler(this.checkBoxDigits_CheckedChanged);
            // 
            // checkBoxSpecial
            // 
            this.checkBoxSpecial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.Font = new System.Drawing.Font("Consolas", 12F);
            this.checkBoxSpecial.Location = new System.Drawing.Point(70, 466);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(153, 27);
            this.checkBoxSpecial.TabIndex = 5;
            this.checkBoxSpecial.Text = "Спецсимволы";
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            this.checkBoxSpecial.CheckedChanged += new System.EventHandler(this.checkBoxSpecial_CheckedChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(470, 313);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(153, 35);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Consolas", 12F);
            this.labelMessage.Location = new System.Drawing.Point(270, 220);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(208, 23);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "Пароль скопирован!";
            this.labelMessage.Visible = false;
            // 
            // labelStrength
            // 
            this.labelStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Consolas", 12F);
            this.labelStrength.Location = new System.Drawing.Point(315, 285);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(109, 23);
            this.labelStrength.TabIndex = 8;
            this.labelStrength.Text = "Сложность";
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownLength.Font = new System.Drawing.Font("Consolas", 12F);
            this.numericUpDownLength.Location = new System.Drawing.Point(148, 317);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownLength.TabIndex = 9;
            this.numericUpDownLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.checkBoxSpecial);
            this.Controls.Add(this.checkBoxDigits);
            this.Controls.Add(this.checkBoxLower);
            this.Controls.Add(this.checkBoxUpper);
            this.Controls.Add(this.BtnGeneration);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button BtnGeneration;
        private System.Windows.Forms.CheckBox checkBoxUpper;
        private System.Windows.Forms.CheckBox checkBoxLower;
        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxSpecial;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
    }
}

