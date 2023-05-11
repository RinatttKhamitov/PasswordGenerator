namespace PasswordGenerator
{
    partial class PasswordGenerateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxMixedChar = new System.Windows.Forms.CheckBox();
            this.checkBoxStrnChar = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordLenght = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxCurse = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 66);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(37, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Генератор Паролей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина пароля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Исключить подобные символы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(28, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Исключить неоднозначные символы:";
            // 
            // checkBoxMixedChar
            // 
            this.checkBoxMixedChar.AutoSize = true;
            this.checkBoxMixedChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBoxMixedChar.Location = new System.Drawing.Point(302, 152);
            this.checkBoxMixedChar.Name = "checkBoxMixedChar";
            this.checkBoxMixedChar.Size = new System.Drawing.Size(163, 17);
            this.checkBoxMixedChar.TabIndex = 4;
            this.checkBoxMixedChar.Text = "( например i, l, 1, L, o, 0, O )";
            this.checkBoxMixedChar.UseVisualStyleBackColor = true;
            // 
            // checkBoxStrnChar
            // 
            this.checkBoxStrnChar.AutoSize = true;
            this.checkBoxStrnChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBoxStrnChar.Location = new System.Drawing.Point(302, 186);
            this.checkBoxStrnChar.Name = "checkBoxStrnChar";
            this.checkBoxStrnChar.Size = new System.Drawing.Size(160, 17);
            this.checkBoxStrnChar.TabIndex = 5;
            this.checkBoxStrnChar.Text = "( { } [ ] ( ) / \\ \' \" ` ~ , ; : . < > )";
            this.checkBoxStrnChar.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(32, 310);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(292, 38);
            this.btnGeneratePassword.TabIndex = 6;
            this.btnGeneratePassword.Text = "Сгенерировать пароль";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(28, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ваш новый пароль:";
            // 
            // passwordLenght
            // 
            this.passwordLenght.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passwordLenght.FormattingEnabled = true;
            this.passwordLenght.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.passwordLenght.Location = new System.Drawing.Point(302, 114);
            this.passwordLenght.Name = "passwordLenght";
            this.passwordLenght.Size = new System.Drawing.Size(121, 21);
            this.passwordLenght.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(170, 375);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(364, 23);
            this.textBoxPassword.TabIndex = 10;
            // 
            // checkBoxCurse
            // 
            this.checkBoxCurse.AutoSize = true;
            this.checkBoxCurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBoxCurse.Location = new System.Drawing.Point(303, 245);
            this.checkBoxCurse.Name = "checkBoxCurse";
            this.checkBoxCurse.Size = new System.Drawing.Size(128, 17);
            this.checkBoxCurse.TabIndex = 12;
            this.checkBoxCurse.Text = "( матерные слова!!!)";
            this.checkBoxCurse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(29, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Генератор \"плохих\" паролей:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.checkBoxCurse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.passwordLenght);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.checkBoxStrnChar);
            this.Controls.Add(this.checkBoxMixedChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxMixedChar;
        private System.Windows.Forms.CheckBox checkBoxStrnChar;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox passwordLenght;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxCurse;
        private System.Windows.Forms.Label label6;
    }
}

