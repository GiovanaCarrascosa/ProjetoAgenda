namespace ProjetoAgenda
{
    partial class frm_tela_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tela_cadastro));
            label6 = new Label();
            txt_nome = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            txt_usuario2 = new TextBox();
            txt_telefone = new TextBox();
            txt_senha2 = new TextBox();
            txt_senha22 = new TextBox();
            btn_cadastrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumTurquoise;
            label6.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 21);
            label6.Name = "label6";
            label6.Size = new Size(118, 34);
            label6.TabIndex = 11;
            label6.Text = "NOME:";
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_nome.Location = new Point(27, 58);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(415, 60);
            txt_nome.TabIndex = 10;
            txt_nome.TextAlign = HorizontalAlignment.Center;
            txt_nome.TextChanged += textBox6_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 130);
            label1.Name = "label1";
            label1.Size = new Size(170, 34);
            label1.TabIndex = 13;
            label1.Text = "USUÁRIO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumTurquoise;
            label7.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 239);
            label7.Name = "label7";
            label7.Size = new Size(201, 34);
            label7.TabIndex = 15;
            label7.Text = "TELEFONE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 500);
            label2.Name = "label2";
            label2.Size = new Size(306, 34);
            label2.TabIndex = 17;
            label2.Text = "REPITA A SENHA:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 390);
            label3.Name = "label3";
            label3.Size = new Size(137, 34);
            label3.TabIndex = 19;
            label3.Text = "SENHA:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(475, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 254);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // txt_usuario2
            // 
            txt_usuario2.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_usuario2.Location = new Point(27, 167);
            txt_usuario2.Multiline = true;
            txt_usuario2.Name = "txt_usuario2";
            txt_usuario2.Size = new Size(415, 60);
            txt_usuario2.TabIndex = 23;
            txt_usuario2.TextAlign = HorizontalAlignment.Center;
            txt_usuario2.TextChanged += txt_usuario2_TextChanged;
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_telefone.Location = new Point(27, 276);
            txt_telefone.Multiline = true;
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(415, 60);
            txt_telefone.TabIndex = 24;
            txt_telefone.TextAlign = HorizontalAlignment.Center;
            txt_telefone.TextChanged += txt_telefone_TextChanged;
            // 
            // txt_senha2
            // 
            txt_senha2.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_senha2.Location = new Point(27, 427);
            txt_senha2.Multiline = true;
            txt_senha2.Name = "txt_senha2";
            txt_senha2.Size = new Size(415, 60);
            txt_senha2.TabIndex = 25;
            txt_senha2.TextAlign = HorizontalAlignment.Center;
            txt_senha2.TextChanged += txt_senha2_TextChanged;
            // 
            // txt_senha22
            // 
            txt_senha22.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_senha22.Location = new Point(27, 537);
            txt_senha22.Multiline = true;
            txt_senha22.Name = "txt_senha22";
            txt_senha22.Size = new Size(415, 60);
            txt_senha22.TabIndex = 26;
            txt_senha22.TextAlign = HorizontalAlignment.Center;
            txt_senha22.TextChanged += txt_senha22_TextChanged;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.PaleTurquoise;
            btn_cadastrar.Enabled = false;
            btn_cadastrar.Font = new Font("Sitka Subheading", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastrar.Location = new Point(499, 533);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(213, 64);
            btn_cadastrar.TabIndex = 27;
            btn_cadastrar.Text = "CADASTRAR:";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(475, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 254);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // frm_tela_cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(744, 621);
            Controls.Add(pictureBox1);
            Controls.Add(btn_cadastrar);
            Controls.Add(txt_senha22);
            Controls.Add(txt_senha2);
            Controls.Add(txt_telefone);
            Controls.Add(txt_usuario2);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(txt_nome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_tela_cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txt_nome;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private TextBox txt_usuario2;
        private TextBox txt_telefone;
        private TextBox txt_senha2;
        private TextBox txt_senha22;
        private Button btn_cadastrar;
        private PictureBox pictureBox1;
    }
}