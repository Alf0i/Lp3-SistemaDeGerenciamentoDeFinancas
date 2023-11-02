namespace SistemaDeGerenc.APPv1
{
    partial class Form_cadastra_receita
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
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            textDesc = new TextBox();
            textCateg = new TextBox();
            textValor = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(454, 566);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(161, 47);
            button1.TabIndex = 27;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(421, 462);
            label6.Name = "label6";
            label6.Size = new Size(104, 24);
            label6.TabIndex = 26;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(421, 372);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 25;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(421, 284);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 24;
            label4.Text = "Valor";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(381, 180);
            label1.Name = "label1";
            label1.Size = new Size(371, 45);
            label1.TabIndex = 22;
            label1.Text = "Cadastre sua receita";
            label1.Click += labelCadastre_Receita;
            // 
            // textDesc
            // 
            textDesc.Location = new Point(421, 491);
            textDesc.Margin = new Padding(3, 4, 3, 4);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(251, 27);
            textDesc.TabIndex = 21;
            // 
            // textCateg
            // 
            textCateg.Location = new Point(421, 402);
            textCateg.Margin = new Padding(3, 4, 3, 4);
            textCateg.Name = "textCateg";
            textCateg.Size = new Size(251, 27);
            textCateg.TabIndex = 20;
            // 
            // textValor
            // 
            textValor.Location = new Point(421, 314);
            textValor.Margin = new Padding(3, 4, 3, 4);
            textValor.Name = "textValor";
            textValor.Size = new Size(251, 27);
            textValor.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(203, 75);
            label3.Name = "label3";
            label3.Size = new Size(752, 58);
            label3.TabIndex = 17;
            label3.Text = "Sistema Gerenciador de Finanças";
            label3.Click += labelTitulo;
            // 
            // Form_cadastra_receita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 744);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textDesc);
            Controls.Add(textCateg);
            Controls.Add(textValor);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_cadastra_receita";
            Text = "Form_cadastra_receita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox textDesc;
        private TextBox textCateg;
        private TextBox textValor;
        private Label label3;
    }
}