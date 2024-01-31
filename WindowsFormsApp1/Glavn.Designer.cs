namespace WindowsFormsApp1
{
    partial class Glavnaya
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
            this.buttonVhod = new System.Windows.Forms.Button();
            this.buttonZaregist = new System.Windows.Forms.Button();
            this.buttonVihod = new System.Windows.Forms.Button();
            this.labelTema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVhod
            // 
            this.buttonVhod.Location = new System.Drawing.Point(271, 115);
            this.buttonVhod.Name = "buttonVhod";
            this.buttonVhod.Size = new System.Drawing.Size(197, 86);
            this.buttonVhod.TabIndex = 0;
            this.buttonVhod.Text = "Войти";
            this.buttonVhod.UseVisualStyleBackColor = true;
            this.buttonVhod.Click += new System.EventHandler(this.buttonVhod_Click);
            // 
            // buttonZaregist
            // 
            this.buttonZaregist.Location = new System.Drawing.Point(271, 232);
            this.buttonZaregist.Name = "buttonZaregist";
            this.buttonZaregist.Size = new System.Drawing.Size(197, 86);
            this.buttonZaregist.TabIndex = 0;
            this.buttonZaregist.Text = "Регистрация";
            this.buttonZaregist.UseVisualStyleBackColor = true;
            this.buttonZaregist.Click += new System.EventHandler(this.buttonZaregist_Click);
            // 
            // buttonVihod
            // 
            this.buttonVihod.Location = new System.Drawing.Point(683, 12);
            this.buttonVihod.Name = "buttonVihod";
            this.buttonVihod.Size = new System.Drawing.Size(105, 38);
            this.buttonVihod.TabIndex = 0;
            this.buttonVihod.Text = "Выход";
            this.buttonVihod.UseVisualStyleBackColor = true;
            this.buttonVihod.Click += new System.EventHandler(this.buttonVihod_Click);
            // 
            // labelTema
            // 
            this.labelTema.AutoSize = true;
            this.labelTema.Location = new System.Drawing.Point(329, 30);
            this.labelTema.Name = "labelTema";
            this.labelTema.Size = new System.Drawing.Size(47, 20);
            this.labelTema.TabIndex = 1;
            this.labelTema.Text = "Тема";
            // 
            // Glavnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTema);
            this.Controls.Add(this.buttonVihod);
            this.Controls.Add(this.buttonZaregist);
            this.Controls.Add(this.buttonVhod);
            this.Name = "Glavnaya";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Glavnaya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVhod;
        private System.Windows.Forms.Button buttonZaregist;
        private System.Windows.Forms.Button buttonVihod;
        private System.Windows.Forms.Label labelTema;
    }
}

