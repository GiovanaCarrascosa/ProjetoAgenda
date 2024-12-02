namespace ProjetoAgenda.Views
{
    partial class frm_tela_agenda
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
            cmbCategoria = new ComboBox();
            btn_excluir = new Button();
            btn_cadastrar = new Button();
            btn_alterar = new Button();
            txt_contato = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_contato = new DataGridView();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_contato).BeginInit();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(31, 140);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(324, 23);
            cmbCategoria.TabIndex = 0;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.RoyalBlue;
            btn_excluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_excluir.Location = new Point(142, 387);
            btn_excluir.Margin = new Padding(3, 2, 3, 2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(92, 40);
            btn_excluir.TabIndex = 1;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.RoyalBlue;
            btn_cadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_cadastrar.Location = new Point(132, 293);
            btn_cadastrar.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(112, 43);
            btn_cadastrar.TabIndex = 2;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = Color.RoyalBlue;
            btn_alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_alterar.Location = new Point(142, 340);
            btn_alterar.Margin = new Padding(3, 2, 3, 2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(92, 43);
            btn_alterar.TabIndex = 3;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = false;
            // 
            // txt_contato
            // 
            txt_contato.Location = new Point(31, 50);
            txt_contato.Margin = new Padding(3, 2, 3, 2);
            txt_contato.Multiline = true;
            txt_contato.Name = "txt_contato";
            txt_contato.Size = new Size(324, 41);
            txt_contato.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(txt_contato);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Location = new Point(29, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(385, 443);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Contato:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 216);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 38);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 192);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 5;
            label3.Text = "TELEFONE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 5;
            label2.Text = "CATEGORIA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 5;
            label1.Text = "CONTATO:";
            // 
            // dgv_contato
            // 
            dgv_contato.BackgroundColor = Color.PowderBlue;
            dgv_contato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contato.Location = new Point(471, 43);
            dgv_contato.Margin = new Padding(3, 2, 3, 2);
            dgv_contato.Name = "dgv_contato";
            dgv_contato.RowHeadersWidth = 51;
            dgv_contato.Size = new Size(335, 313);
            dgv_contato.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(760, 416);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(78, 38);
            button4.TabIndex = 7;
            button4.Text = "Sair";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // frm_tela_agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(850, 465);
            Controls.Add(button4);
            Controls.Add(dgv_contato);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_tela_agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            Load += frm_tela_agenda_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_contato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCategoria;
        private Button btn_excluir;
        private Button btn_cadastrar;
        private Button btn_alterar;
        private TextBox txt_contato;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DataGridView dgv_contato;
        private Button button4;
        private TextBox textBox1;
        private Label label3;
    }
}