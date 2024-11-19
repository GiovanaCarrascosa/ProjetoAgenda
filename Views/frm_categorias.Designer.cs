﻿namespace ProjetoAgenda.Views
{
    partial class frm_categorias
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
            groupBox1 = new GroupBox();
            btn_cadastrar_categoria = new Button();
            txt_categoria = new TextBox();
            btn_fechar_categoria = new Button();
            dgvCategoria = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_cadastrar_categoria);
            groupBox1.Controls.Add(txt_categoria);
            groupBox1.Location = new Point(74, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira a nova categoria:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_cadastrar_categoria
            // 
            btn_cadastrar_categoria.BackColor = Color.MediumAquamarine;
            btn_cadastrar_categoria.Font = new Font("SansSerif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn_cadastrar_categoria.Location = new Point(60, 112);
            btn_cadastrar_categoria.Name = "btn_cadastrar_categoria";
            btn_cadastrar_categoria.Size = new Size(179, 62);
            btn_cadastrar_categoria.TabIndex = 1;
            btn_cadastrar_categoria.Text = "Cadastrar";
            btn_cadastrar_categoria.UseVisualStyleBackColor = false;
            btn_cadastrar_categoria.Click += btn_cadastrar_categoria_Click;
            // 
            // txt_categoria
            // 
            txt_categoria.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_categoria.Location = new Point(23, 35);
            txt_categoria.Multiline = true;
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(252, 55);
            txt_categoria.TabIndex = 0;
            txt_categoria.TextAlign = HorizontalAlignment.Center;
            txt_categoria.TextChanged += txt_categoria_TextChanged;
            // 
            // btn_fechar_categoria
            // 
            btn_fechar_categoria.BackColor = Color.MediumSeaGreen;
            btn_fechar_categoria.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn_fechar_categoria.Location = new Point(10, 283);
            btn_fechar_categoria.Name = "btn_fechar_categoria";
            btn_fechar_categoria.Size = new Size(90, 30);
            btn_fechar_categoria.TabIndex = 1;
            btn_fechar_categoria.Text = "Fechar";
            btn_fechar_categoria.UseVisualStyleBackColor = false;
            btn_fechar_categoria.Click += btn_fechar_categoria_Click;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(432, 64);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(416, 189);
            dgvCategoria.TabIndex = 2;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(584, 258);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(121, 44);
            button1.TabIndex = 3;
            button1.Text = "EXCLUIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(447, 31);
            label1.Name = "label1";
            label1.Size = new Size(390, 18);
            label1.TabIndex = 4;
            label1.Text = "Selecione alguma linha que você quiser excluir:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(872, 322);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgvCategoria);
            Controls.Add(btn_fechar_categoria);
            Controls.Add(groupBox1);
            Name = "frm_categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            Load += frm_categorias_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_cadastrar_categoria;
        private TextBox txt_categoria;
        private Button btn_fechar_categoria;
        private DataGridView dgvCategoria;
        private Button button1;
        private Label label1;
    }
}