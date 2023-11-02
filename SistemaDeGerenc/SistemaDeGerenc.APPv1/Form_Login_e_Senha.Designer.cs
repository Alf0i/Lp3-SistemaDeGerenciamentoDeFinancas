namespace SistemaDeGerenc.APPv1
{
    partial class Form_Login_e_Senha
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textEmail = new TextBox();
            textSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(571, 479);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(102, 31);
            button1.TabIndex = 0;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btoLogar;
            // 
            // textEmail
            // 
            textEmail.BackColor = SystemColors.Window;
            textEmail.Location = new Point(447, 367);
            textEmail.Margin = new Padding(3, 4, 3, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(212, 27);
            textEmail.TabIndex = 1;
            
            // 
            // textSenha
            // 
            textSenha.Location = new Point(447, 440);
            textSenha.Margin = new Padding(3, 4, 3, 4);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(212, 27);
            textSenha.TabIndex = 2;
            textSenha.TextChanged += textBoxSenha;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(447, 315);
            label1.Name = "label1";
            label1.Size = new Size(328, 33);
            label1.TabIndex = 3;
            label1.Text = "Nome de Usuário(Email)\r\n";
            label1.Click += labelLogin;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(447, 401);
            label2.Name = "label2";
            label2.Size = new Size(94, 33);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            label2.Click += labelSenha;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(226, 149);
            label3.Name = "label3";
            label3.Size = new Size(752, 58);
            label3.TabIndex = 5;
            label3.Text = "Sistema Gerenciador de Finanças";
            label3.Click += labelTitulo;
            // 
            // Form_Login_e_Senha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 741);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSenha);
            Controls.Add(textEmail);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Login_e_Senha";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textEmail;
        private TextBox textSenha;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}