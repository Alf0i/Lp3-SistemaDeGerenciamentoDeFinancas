﻿namespace SistemaDeGerenc.APPv1
{
    partial class Form_Mostra_Tabela
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            Despesa = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 284);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1058, 437);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(497, 209);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(123, 53);
            button2.TabIndex = 6;
            button2.Text = "Confirma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(441, 171);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(224, 12);
            label3.Name = "label3";
            label3.Size = new Size(752, 58);
            label3.TabIndex = 18;
            label3.Text = "Sistema Gerenciador de Finanças";
            // 
            // Despesa
            // 
            Despesa.AutoSize = true;
            Despesa.BackColor = Color.Transparent;
            Despesa.Font = new Font("Constantia", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Despesa.ForeColor = Color.Black;
            Despesa.Location = new Point(371, 93);
            Despesa.Name = "Despesa";
            Despesa.Size = new Size(422, 45);
            Despesa.TabIndex = 19;
            Despesa.Text = "Oque deseja consultar?";
            Despesa.Click += Despesa_Label;
            // 
            // Form_Mostra_Tabela
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 751);
            Controls.Add(Despesa);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Mostra_Tabela";
            Text = "Form_Mostra_Tabela";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label3;
        private Label Despesa;
    }
}