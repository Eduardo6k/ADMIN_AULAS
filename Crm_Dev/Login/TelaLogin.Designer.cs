namespace Crm_Dev
{
    partial class TelaLogin
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
            btn_login = new Button();
            txb_nome = new TextBox();
            lbl_nome = new Label();
            txb_senha = new TextBox();
            lbl_senha = new Label();
            gpb_div = new GroupBox();
            lbl_Cadastro = new Label();
            bnt_Cadastro = new Button();
            label1 = new Label();
            lbl_User = new Label();
            gpb_div.SuspendLayout();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.GradientInactiveCaption;
            btn_login.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(115, 282);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(405, 59);
            btn_login.TabIndex = 0;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txb_nome
            // 
            txb_nome.BorderStyle = BorderStyle.FixedSingle;
            txb_nome.Location = new Point(115, 88);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(405, 34);
            txb_nome.TabIndex = 1;
            txb_nome.KeyDown += txb_nome_KeyDown;
            txb_nome.KeyPress += txb_nome_KeyPress;
            txb_nome.MouseEnter += txb_nome_MouseEnter;
            txb_nome.MouseLeave += txb_nome_MouseLeave;
            // 
            // lbl_nome
            // 
            lbl_nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(113, 57);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(84, 28);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "NOME :";
            // 
            // txb_senha
            // 
            txb_senha.BorderStyle = BorderStyle.FixedSingle;
            txb_senha.Location = new Point(115, 210);
            txb_senha.Name = "txb_senha";
            txb_senha.Size = new Size(405, 34);
            txb_senha.TabIndex = 3;
            txb_senha.UseSystemPasswordChar = true;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(113, 179);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(84, 28);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "SENHA:";
            // 
            // gpb_div
            // 
            gpb_div.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpb_div.BackColor = SystemColors.InactiveCaption;
            gpb_div.Controls.Add(lbl_User);
            gpb_div.Controls.Add(btn_login);
            gpb_div.Controls.Add(lbl_senha);
            gpb_div.Controls.Add(txb_senha);
            gpb_div.Controls.Add(lbl_nome);
            gpb_div.Controls.Add(txb_nome);
            gpb_div.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gpb_div.Location = new Point(190, 13);
            gpb_div.Margin = new Padding(3, 4, 3, 3);
            gpb_div.MaximumSize = new Size(616, 490);
            gpb_div.MinimumSize = new Size(616, 490);
            gpb_div.Name = "gpb_div";
            gpb_div.Size = new Size(616, 490);
            gpb_div.TabIndex = 5;
            gpb_div.TabStop = false;
            gpb_div.Text = "LOGIN";
            // 
            // lbl_Cadastro
            // 
            lbl_Cadastro.AutoSize = true;
            lbl_Cadastro.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_Cadastro.Location = new Point(195, 586);
            lbl_Cadastro.Name = "lbl_Cadastro";
            lbl_Cadastro.Size = new Size(192, 23);
            lbl_Cadastro.TabIndex = 1;
            lbl_Cadastro.Text = "NÃO TEM CADASTRO?";
            // 
            // bnt_Cadastro
            // 
            bnt_Cadastro.BackColor = Color.WhiteSmoke;
            bnt_Cadastro.Cursor = Cursors.Hand;
            bnt_Cadastro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            bnt_Cadastro.Location = new Point(507, 580);
            bnt_Cadastro.Name = "bnt_Cadastro";
            bnt_Cadastro.Size = new Size(299, 29);
            bnt_Cadastro.TabIndex = 6;
            bnt_Cadastro.Text = "Se Cadastrar";
            bnt_Cadastro.UseVisualStyleBackColor = false;
            bnt_Cadastro.Click += bnt_Cadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(393, 586);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 7;
            label1.Text = ">>>";
            // 
            // lbl_User
            // 
            lbl_User.AutoSize = true;
            lbl_User.Location = new Point(116, 131);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(0, 28);
            lbl_User.TabIndex = 5;
            // 
            // TelaLogin
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1049, 700);
            Controls.Add(label1);
            Controls.Add(bnt_Cadastro);
            Controls.Add(lbl_Cadastro);
            Controls.Add(gpb_div);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += Form1_Load;
            gpb_div.ResumeLayout(false);
            gpb_div.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txb_nome;
        private Label lbl_nome;
        private TextBox txb_senha;
        private Label lbl_senha;
        private GroupBox gpb_div;
        private Label lbl_Cadastro;
        private Button bnt_Cadastro;
        private Label label1;
        private Label lbl_User;
    }
}