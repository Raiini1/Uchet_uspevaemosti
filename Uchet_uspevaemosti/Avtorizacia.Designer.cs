namespace Uchet_uspevaemosti
{
    partial class Avtorizacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorizacia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxParol = new System.Windows.Forms.TextBox();
            this.buttonVoiti = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelUchitel = new System.Windows.Forms.LinkLabel();
            this.linkLabelUchenik = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(116, 13);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(135, 22);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxParol
            // 
            this.textBoxParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParol.Location = new System.Drawing.Point(116, 57);
            this.textBoxParol.Name = "textBoxParol";
            this.textBoxParol.Size = new System.Drawing.Size(135, 22);
            this.textBoxParol.TabIndex = 3;
            // 
            // buttonVoiti
            // 
            this.buttonVoiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVoiti.Location = new System.Drawing.Point(16, 160);
            this.buttonVoiti.Name = "buttonVoiti";
            this.buttonVoiti.Size = new System.Drawing.Size(280, 32);
            this.buttonVoiti.TabIndex = 4;
            this.buttonVoiti.Text = "Войти";
            this.buttonVoiti.UseVisualStyleBackColor = true;
            this.buttonVoiti.Click += new System.EventHandler(this.buttonVoiti_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxParol);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 93);
            this.panel1.TabIndex = 5;
            // 
            // linkLabelUchitel
            // 
            this.linkLabelUchitel.AutoSize = true;
            this.linkLabelUchitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelUchitel.Location = new System.Drawing.Point(8, 219);
            this.linkLabelUchitel.Name = "linkLabelUchitel";
            this.linkLabelUchitel.Size = new System.Drawing.Size(137, 18);
            this.linkLabelUchitel.TabIndex = 6;
            this.linkLabelUchitel.TabStop = true;
            this.linkLabelUchitel.Text = "Войти как учитель";
            // 
            // linkLabelUchenik
            // 
            this.linkLabelUchenik.AutoSize = true;
            this.linkLabelUchenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelUchenik.Location = new System.Drawing.Point(167, 219);
            this.linkLabelUchenik.Name = "linkLabelUchenik";
            this.linkLabelUchenik.Size = new System.Drawing.Size(129, 18);
            this.linkLabelUchenik.TabIndex = 7;
            this.linkLabelUchenik.TabStop = true;
            this.linkLabelUchenik.Text = "Войти как ученик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вход за администратора";
            // 
            // Avtorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelUchenik);
            this.Controls.Add(this.linkLabelUchitel);
            this.Controls.Add(this.buttonVoiti);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtorizacia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Avtorizacia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxParol;
        private System.Windows.Forms.Button buttonVoiti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelUchitel;
        private System.Windows.Forms.LinkLabel linkLabelUchenik;
        private System.Windows.Forms.Label label3;
    }
}