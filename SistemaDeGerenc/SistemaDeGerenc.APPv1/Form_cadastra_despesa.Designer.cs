namespace SistemaDeGerenc.APPv1
{
    partial class Form_cadastra_despesa
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
            textValor = new TextBox();
            textCateg = new TextBox();
            textDesc = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(194, 31);
            label3.Name = "label3";
            label3.Size = new Size(752, 58);
            label3.TabIndex = 6;
            label3.Text = "Sistema Gerenciador de Finanças";
            label3.Click += labelTitulo;
            // 
            // textValor
            // 
            textValor.Location = new Point(412, 294);
            textValor.Margin = new Padding(3, 4, 3, 4);
            textValor.Name = "textValor";
            textValor.Size = new Size(251, 27);
            textValor.TabIndex = 8;
            textValor.TextChanged += textBoxValor;
            // 
            // textCateg
            // 
            textCateg.Location = new Point(412, 382);
            textCateg.Margin = new Padding(3, 4, 3, 4);
            textCateg.Name = "textCateg";
            textCateg.Size = new Size(251, 27);
            textCateg.TabIndex = 9;
            textCateg.TextChanged += textBoxCategoria;
            // 
            // textDesc
            // 
            textDesc.Location = new Point(412, 471);
            textDesc.Margin = new Padding(3, 4, 3, 4);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(251, 27);
            textDesc.TabIndex = 10;
            textDesc.TextChanged += textBoxDesc;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(371, 136);
            label1.Name = "label1";
            label1.Size = new Size(389, 45);
            label1.TabIndex = 11;
            label1.Text = "Cadastre sua despesa";
            label1.Click += labelCadastraReceita;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(412, 264);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 13;
            label4.Text = "Valor";
            label4.Click += labelValor;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(412, 352);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 14;
            label5.Text = "Categoria";
            label5.Click += labelCategoria;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(412, 442);
            label6.Name = "label6";
            label6.Size = new Size(104, 24);
            label6.TabIndex = 15;
            label6.Text = "Descrição";
            label6.Click += labelDesc;
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(446, 546);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(161, 47);
            button1.TabIndex = 16;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btoCadastrar;
            // 
            // Form_cadastra_despesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 748);
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
            Name = "Form_cadastra_despesa";
            Text = "Form_cadastra_despesa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private TextBox textValor;
        private TextBox textCateg;
        private TextBox textDesc;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}