namespace SistemaDeGerenc.APPv1
{
    partial class FormMenu
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
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(188, 53);
            label3.Name = "label3";
            label3.Size = new Size(593, 45);
            label3.TabIndex = 6;
            label3.Text = "Sistema Gerenciador de Finanças";
            label3.Click += labelTitulo;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(450, 135);
            label1.Name = "label1";
            label1.Size = new Size(92, 36);
            label1.TabIndex = 7;
            label1.Text = "Menu";
            label1.Click += labelMenu;
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(188, 234);
            button1.Name = "button1";
            button1.Size = new Size(141, 59);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar Despesa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btoCadastraDespesa;
            // 
            // button2
            // 
            button2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(417, 234);
            button2.Name = "button2";
            button2.Size = new Size(141, 59);
            button2.TabIndex = 9;
            button2.Text = "Cadastrar Receita";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btoCadastraReceita;
            // 
            // button3
            // 
            button3.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(640, 234);
            button3.Name = "button3";
            button3.Size = new Size(141, 59);
            button3.TabIndex = 10;
            button3.Text = "Calcular Saldo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btoCalculaSaldo;
            // 
            // button4
            // 
            button4.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(283, 347);
            button4.Name = "button4";
            button4.Size = new Size(141, 59);
            button4.TabIndex = 11;
            button4.Text = "Classificar Despesas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btoClassificaDespesa;
            // 
            // button5
            // 
            button5.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(521, 347);
            button5.Name = "button5";
            button5.Size = new Size(141, 59);
            button5.TabIndex = 12;
            button5.Text = "Realizar Filtros";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btoRealizaFiltros;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 556);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}