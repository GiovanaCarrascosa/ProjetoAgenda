﻿namespace ProjetoAgenda
{
    partial class frm_tela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tela_login));
            btn_entrar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btn_cadastrar = new Button();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.PaleTurquoise;
            btn_entrar.Enabled = false;
            btn_entrar.Font = new Font("Sitka Subheading", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_entrar.Location = new Point(115, 243);
            btn_entrar.Margin = new Padding(2);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(137, 49);
            btn_entrar.TabIndex = 0;
            btn_entrar.Text = "ENTRAR";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 29);
            label1.TabIndex = 5;
            label1.Text = "USUÁRIO:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(384, -27);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 462);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("Modern No. 20", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 29);
            label2.TabIndex = 8;
            label2.Text = "SENHA:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.PaleTurquoise;
            btn_cadastrar.Font = new Font("Sitka Subheading", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastrar.Location = new Point(94, 305);
            btn_cadastrar.Margin = new Padding(2);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(181, 51);
            btn_cadastrar.TabIndex = 10;
            btn_cadastrar.Text = "CADASTRAR:";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += button2_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_usuario.Location = new Point(19, 61);
            txt_usuario.Margin = new Padding(2);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(333, 49);
            txt_usuario.TabIndex = 11;
            txt_usuario.TextAlign = HorizontalAlignment.Center;
            txt_usuario.TextChanged += textBox6_TextChanged;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_senha.Location = new Point(19, 166);
            txt_senha.Margin = new Padding(2);
            txt_senha.Multiline = true;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(333, 49);
            txt_senha.TabIndex = 12;
            txt_senha.TextAlign = HorizontalAlignment.Center;
            txt_senha.TextChanged += txt_senha_TextChanged;
            // 
            // frm_tela_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(831, 402);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(btn_cadastrar);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_entrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frm_tela_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_entrar;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btn_cadastrar;
        private TextBox txt_usuario;
        private TextBox txt_senha;
    }
}
