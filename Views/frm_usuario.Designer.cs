﻿namespace ProjetoAgenda.Views
{
    partial class frm_usuario
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
            dgv_usuario = new DataGridView();
            btn_excluir = new Button();
            groupBox1 = new GroupBox();
            txt_nova_senha = new TextBox();
            btn_alterar_senha = new Button();
            btn_fechar_categoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_usuario
            // 
            dgv_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuario.Location = new Point(30, 48);
            dgv_usuario.Name = "dgv_usuario";
            dgv_usuario.RowHeadersWidth = 51;
            dgv_usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_usuario.Size = new Size(353, 333);
            dgv_usuario.TabIndex = 0;
            dgv_usuario.CellContentClick += dgv_usuario_CellContentClick;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.LightSeaGreen;
            btn_excluir.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_excluir.Location = new Point(123, 387);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(152, 52);
            btn_excluir.TabIndex = 1;
            btn_excluir.Text = "EXCLUIR";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_nova_senha);
            groupBox1.Controls.Add(btn_alterar_senha);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(456, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 277);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar senha:";
            // 
            // txt_nova_senha
            // 
            txt_nova_senha.Location = new Point(23, 85);
            txt_nova_senha.Multiline = true;
            txt_nova_senha.Name = "txt_nova_senha";
            txt_nova_senha.Size = new Size(295, 60);
            txt_nova_senha.TabIndex = 1;
            // 
            // btn_alterar_senha
            // 
            btn_alterar_senha.BackColor = Color.LightSeaGreen;
            btn_alterar_senha.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_alterar_senha.Location = new Point(57, 165);
            btn_alterar_senha.Name = "btn_alterar_senha";
            btn_alterar_senha.Size = new Size(215, 59);
            btn_alterar_senha.TabIndex = 0;
            btn_alterar_senha.Text = "ALTERAR SENHA";
            btn_alterar_senha.UseVisualStyleBackColor = false;
            btn_alterar_senha.Click += button2_Click;
            // 
            // btn_fechar_categoria
            // 
            btn_fechar_categoria.BackColor = Color.MediumSeaGreen;
            btn_fechar_categoria.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btn_fechar_categoria.Location = new Point(749, 397);
            btn_fechar_categoria.Margin = new Padding(3, 4, 3, 4);
            btn_fechar_categoria.Name = "btn_fechar_categoria";
            btn_fechar_categoria.Size = new Size(103, 40);
            btn_fechar_categoria.TabIndex = 3;
            btn_fechar_categoria.Text = "Fechar";
            btn_fechar_categoria.UseVisualStyleBackColor = false;
            btn_fechar_categoria.Click += btn_fechar_categoria_Click;
            // 
            // frm_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(864, 451);
            Controls.Add(btn_fechar_categoria);
            Controls.Add(groupBox1);
            Controls.Add(btn_excluir);
            Controls.Add(dgv_usuario);
            Name = "frm_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuário";
            Load += frm_usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_usuario;
        private Button btn_excluir;
        private GroupBox groupBox1;
        private Button btn_alterar_senha;
        private TextBox txt_nova_senha;
        private Button btn_fechar_categoria;
    }
}