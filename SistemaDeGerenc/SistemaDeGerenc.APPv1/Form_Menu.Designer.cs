namespace SistemaDeGerenc.APPv1
{
    partial class Form2
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
            label3.Location = new Point(200, 36);
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
            label1.Font = new Font("Constantia", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(452, 126);
            label1.Name = "label1";
            label1.Size = new Size(112, 42);
            label1.TabIndex = 9;
            label1.Text = "Menu";
            label1.Click += labelMenu;
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(200, 220);
            button1.Name = "button1";
            button1.Size = new Size(157, 71);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar Despesa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(435, 220);
            button2.Name = "button2";
            button2.Size = new Size(149, 71);
            button2.TabIndex = 11;
            button2.Text = "Cadastrar Receita";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(662, 220);
            button3.Name = "button3";
            button3.Size = new Size(149, 71);
            button3.TabIndex = 12;
            button3.Text = "Cálculo do Saldo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(307, 343);
            button4.Name = "button4";
            button4.Size = new Size(157, 71);
            button4.TabIndex = 13;
            button4.Text = "Classificação de Despesas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(557, 343);
            button5.Name = "button5";
            button5.Size = new Size(157, 71);
            button5.TabIndex = 14;
            button5.Text = "Realização de Filtros";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 557);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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