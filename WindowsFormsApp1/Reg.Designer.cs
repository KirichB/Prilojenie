namespace WindowsFormsApp1
{
    partial class Registraciya
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password = new System.Windows.Forms.TextBox();
            this.labelUjezaReg = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.labelpas = new System.Windows.Forms.Label();
            this.labelVvediteDan = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(94, 183);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(203, 26);
            this.Password.TabIndex = 0;
            // 
            // labelUjezaReg
            // 
            this.labelUjezaReg.AutoSize = true;
            this.labelUjezaReg.Location = new System.Drawing.Point(90, 370);
            this.labelUjezaReg.Name = "labelUjezaReg";
            this.labelUjezaReg.Size = new System.Drawing.Size(194, 20);
            this.labelUjezaReg.TabIndex = 1;
            this.labelUjezaReg.Text = "Уже зарегистрированы?";
            this.labelUjezaReg.Click += new System.EventHandler(this.labelUjezaReg_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(12, 133);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(55, 20);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Логин";
            // 
            // labelpas
            // 
            this.labelpas.AutoSize = true;
            this.labelpas.Location = new System.Drawing.Point(12, 189);
            this.labelpas.Name = "labelpas";
            this.labelpas.Size = new System.Drawing.Size(67, 20);
            this.labelpas.TabIndex = 1;
            this.labelpas.Text = "Пароль";
            // 
            // labelVvediteDan
            // 
            this.labelVvediteDan.AutoSize = true;
            this.labelVvediteDan.Location = new System.Drawing.Point(115, 77);
            this.labelVvediteDan.Name = "labelVvediteDan";
            this.labelVvediteDan.Size = new System.Drawing.Size(138, 20);
            this.labelVvediteDan.TabIndex = 1;
            this.labelVvediteDan.Text = "Введите данные";
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(83, 312);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(203, 41);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Location = new System.Drawing.Point(279, 12);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(75, 34);
            this.buttonNazad.TabIndex = 3;
            this.buttonNazad.Text = "Назад";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // Login
            // 
            this.Login.FormattingEnabled = true;
            this.Login.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.Login.Location = new System.Drawing.Point(94, 124);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(203, 28);
            this.Login.TabIndex = 4;
            this.Login.SelectedIndexChanged += new System.EventHandler(this.Login_SelectedIndexChanged);
            // 
            // Registraciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.labelVvediteDan);
            this.Controls.Add(this.labelpas);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.labelUjezaReg);
            this.Controls.Add(this.Password);
            this.Name = "Registraciya";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registraciya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label labelUjezaReg;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label labelpas;
        private System.Windows.Forms.Label labelVvediteDan;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.ComboBox Login;
    }
}