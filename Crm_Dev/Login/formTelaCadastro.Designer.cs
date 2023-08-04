namespace Crm_Dev
{
    partial class frm_TelaCadastro
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            lbl_CpfOutPut = new Label();
            msk_tbx_CPF = new MaskedTextBox();
            lbl_SenhaOutPut = new Label();
            lbl_CPF = new Label();
            cbx_VerSenha = new CheckBox();
            cbx_SenhaCadastro = new TextBox();
            txb_Nome = new TextBox();
            lbl_senha = new Label();
            lbl_Nome = new Label();
            btn_Cancelar = new Button();
            btn_Continuar = new Button();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_CpfOutPut);
            groupBox1.Controls.Add(msk_tbx_CPF);
            groupBox1.Controls.Add(lbl_SenhaOutPut);
            groupBox1.Controls.Add(lbl_CPF);
            groupBox1.Controls.Add(cbx_VerSenha);
            groupBox1.Controls.Add(cbx_SenhaCadastro);
            groupBox1.Controls.Add(txb_Nome);
            groupBox1.Controls.Add(lbl_senha);
            groupBox1.Controls.Add(lbl_Nome);
            groupBox1.Controls.Add(btn_Cancelar);
            groupBox1.Controls.Add(btn_Continuar);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(137, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 395);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CADASTRO DE UMA CONTA NOVA";
            // 
            // lbl_CpfOutPut
            // 
            lbl_CpfOutPut.AutoSize = true;
            lbl_CpfOutPut.Location = new Point(129, 295);
            lbl_CpfOutPut.Name = "lbl_CpfOutPut";
            lbl_CpfOutPut.Size = new Size(0, 28);
            lbl_CpfOutPut.TabIndex = 12;
            // 
            // msk_tbx_CPF
            // 
            msk_tbx_CPF.Location = new Point(129, 251);
            msk_tbx_CPF.Mask = "000,000,000-00";
            msk_tbx_CPF.Name = "msk_tbx_CPF";
            msk_tbx_CPF.Size = new Size(359, 34);
            msk_tbx_CPF.TabIndex = 11;
            // 
            // lbl_SenhaOutPut
            // 
            lbl_SenhaOutPut.AutoSize = true;
            lbl_SenhaOutPut.Location = new Point(129, 190);
            lbl_SenhaOutPut.Name = "lbl_SenhaOutPut";
            lbl_SenhaOutPut.Size = new Size(0, 28);
            lbl_SenhaOutPut.TabIndex = 10;
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Location = new Point(33, 251);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(87, 28);
            lbl_CPF.TabIndex = 8;
            lbl_CPF.Text = "CPF      :";
            // 
            // cbx_VerSenha
            // 
            cbx_VerSenha.AutoSize = true;
            cbx_VerSenha.Checked = true;
            cbx_VerSenha.CheckState = CheckState.Checked;
            cbx_VerSenha.Location = new Point(461, 163);
            cbx_VerSenha.Name = "cbx_VerSenha";
            cbx_VerSenha.Size = new Size(18, 17);
            cbx_VerSenha.TabIndex = 7;
            cbx_VerSenha.UseVisualStyleBackColor = true;
            cbx_VerSenha.Click += cbx_VerSenha_Click;
            // 
            // cbx_SenhaCadastro
            // 
            cbx_SenhaCadastro.Location = new Point(129, 153);
            cbx_SenhaCadastro.Name = "cbx_SenhaCadastro";
            cbx_SenhaCadastro.PasswordChar = '*';
            cbx_SenhaCadastro.Size = new Size(359, 34);
            cbx_SenhaCadastro.TabIndex = 5;
            cbx_SenhaCadastro.KeyDown += textBox2_KeyDown;
            // 
            // txb_Nome
            // 
            txb_Nome.Location = new Point(123, 87);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(365, 34);
            txb_Nome.TabIndex = 4;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(33, 159);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(90, 28);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "SENHA :";
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(33, 93);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(90, 28);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "NOME  :";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Cursor = Cursors.No;
            btn_Cancelar.Location = new Point(263, 332);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(103, 36);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Continuar
            // 
            btn_Continuar.Cursor = Cursors.Hand;
            btn_Continuar.Location = new Point(396, 333);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.RightToLeft = RightToLeft.No;
            btn_Continuar.Size = new Size(114, 35);
            btn_Continuar.TabIndex = 0;
            btn_Continuar.Text = "Continuar";
            btn_Continuar.TextAlign = ContentAlignment.TopLeft;
            btn_Continuar.UseVisualStyleBackColor = true;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // frm_TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(997, 615);
            Controls.Add(groupBox1);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frm_TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Cancelar;
        private Button btn_Continuar;
        private TextBox cbx_SenhaCadastro;
        private TextBox txb_Nome;
        private Label lbl_senha;
        private Label lbl_Nome;
        private ImageList imageList1;
        private CheckBox cbx_VerSenha;
        private Label lbl_CPF;
        private Label lbl_SenhaOutPut;
        private MaskedTextBox msk_tbx_CPF;
        private Label lbl_CpfOutPut;
    }
}