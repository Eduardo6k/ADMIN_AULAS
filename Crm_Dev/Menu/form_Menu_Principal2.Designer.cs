
namespace Crm_Dev.Menu
{

    partial class form_Menu_Principal2
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Esquerdo = new Panel();
            IB_Teste = new FontAwesome.Sharp.IconButton();
            IB_Atividades = new FontAwesome.Sharp.IconButton();
            IB_NOTAS = new FontAwesome.Sharp.IconButton();
            IB_AULA = new FontAwesome.Sharp.IconButton();
            panel_Logo = new Panel();
            pictureBox1 = new PictureBox();
            panel_Topo = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tabControl_Centro = new TabControl();
            panel_Esquerdo.SuspendLayout();
            panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Esquerdo
            // 
            panel_Esquerdo.BackColor = Color.FromArgb(30, 31, 68);
            panel_Esquerdo.BorderStyle = BorderStyle.FixedSingle;
            panel_Esquerdo.Controls.Add(IB_Teste);
            panel_Esquerdo.Controls.Add(IB_Atividades);
            panel_Esquerdo.Controls.Add(IB_NOTAS);
            panel_Esquerdo.Controls.Add(IB_AULA);
            panel_Esquerdo.Controls.Add(panel_Logo);
            panel_Esquerdo.Dock = DockStyle.Left;
            panel_Esquerdo.Location = new Point(0, 0);
            panel_Esquerdo.Margin = new Padding(4);
            panel_Esquerdo.Name = "panel_Esquerdo";
            panel_Esquerdo.Size = new Size(303, 763);
            panel_Esquerdo.TabIndex = 0;
            // 
            // IB_Teste
            // 
            IB_Teste.BackgroundImageLayout = ImageLayout.None;
            IB_Teste.Dock = DockStyle.Top;
            IB_Teste.FlatAppearance.BorderSize = 0;
            IB_Teste.FlatStyle = FlatStyle.Flat;
            IB_Teste.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            IB_Teste.ForeColor = SystemColors.ControlLightLight;
            IB_Teste.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            IB_Teste.IconColor = Color.Brown;
            IB_Teste.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IB_Teste.ImageAlign = ContentAlignment.MiddleLeft;
            IB_Teste.Location = new Point(0, 528);
            IB_Teste.Margin = new Padding(4);
            IB_Teste.Name = "IB_Teste";
            IB_Teste.Padding = new Padding(27, 0, 0, 0);
            IB_Teste.Size = new Size(301, 116);
            IB_Teste.TabIndex = 6;
            IB_Teste.Text = "TESTES";
            IB_Teste.UseVisualStyleBackColor = true;
            // 
            // IB_Atividades
            // 
            IB_Atividades.BackgroundImageLayout = ImageLayout.None;
            IB_Atividades.Dock = DockStyle.Top;
            IB_Atividades.FlatAppearance.BorderSize = 0;
            IB_Atividades.FlatStyle = FlatStyle.Flat;
            IB_Atividades.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            IB_Atividades.ForeColor = SystemColors.ControlLightLight;
            IB_Atividades.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            IB_Atividades.IconColor = SystemColors.Highlight;
            IB_Atividades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IB_Atividades.IconSize = 40;
            IB_Atividades.ImageAlign = ContentAlignment.MiddleLeft;
            IB_Atividades.Location = new Point(0, 412);
            IB_Atividades.Margin = new Padding(4);
            IB_Atividades.Name = "IB_Atividades";
            IB_Atividades.Padding = new Padding(13, 0, 0, 0);
            IB_Atividades.Size = new Size(301, 116);
            IB_Atividades.TabIndex = 4;
            IB_Atividades.Text = "    ATIVIDADES";
            IB_Atividades.UseVisualStyleBackColor = true;
            // 
            // IB_NOTAS
            // 
            IB_NOTAS.BackgroundImageLayout = ImageLayout.None;
            IB_NOTAS.Dock = DockStyle.Top;
            IB_NOTAS.FlatAppearance.BorderSize = 0;
            IB_NOTAS.FlatStyle = FlatStyle.Flat;
            IB_NOTAS.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            IB_NOTAS.ForeColor = SystemColors.ControlLightLight;
            IB_NOTAS.IconChar = FontAwesome.Sharp.IconChar.Question;
            IB_NOTAS.IconColor = Color.DeepPink;
            IB_NOTAS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IB_NOTAS.ImageAlign = ContentAlignment.MiddleLeft;
            IB_NOTAS.Location = new Point(0, 296);
            IB_NOTAS.Margin = new Padding(4);
            IB_NOTAS.Name = "IB_NOTAS";
            IB_NOTAS.Padding = new Padding(27, 0, 0, 0);
            IB_NOTAS.Size = new Size(301, 116);
            IB_NOTAS.TabIndex = 3;
            IB_NOTAS.Text = "NOTAS";
            IB_NOTAS.UseVisualStyleBackColor = true;
            IB_NOTAS.Click += IB_NOTAS_Click;
            // 
            // IB_AULA
            // 
            IB_AULA.BackgroundImageLayout = ImageLayout.None;
            IB_AULA.Dock = DockStyle.Top;
            IB_AULA.FlatAppearance.BorderSize = 0;
            IB_AULA.FlatStyle = FlatStyle.Flat;
            IB_AULA.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            IB_AULA.ForeColor = SystemColors.ControlLightLight;
            IB_AULA.IconChar = FontAwesome.Sharp.IconChar.Palette;
            IB_AULA.IconColor = SystemColors.HighlightText;
            IB_AULA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IB_AULA.ImageAlign = ContentAlignment.MiddleLeft;
            IB_AULA.Location = new Point(0, 180);
            IB_AULA.Margin = new Padding(4);
            IB_AULA.Name = "IB_AULA";
            IB_AULA.Padding = new Padding(27, 0, 0, 0);
            IB_AULA.Size = new Size(301, 116);
            IB_AULA.TabIndex = 2;
            IB_AULA.Text = "AULA";
            IB_AULA.UseVisualStyleBackColor = true;
            IB_AULA.Click += IB_AULA_Click;
            // 
            // panel_Logo
            // 
            panel_Logo.Controls.Add(pictureBox1);
            panel_Logo.Dock = DockStyle.Top;
            panel_Logo.Location = new Point(0, 0);
            panel_Logo.Margin = new Padding(4);
            panel_Logo.Name = "panel_Logo";
            panel_Logo.Size = new Size(301, 180);
            panel_Logo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = ADMIN_AULAS.Properties.Resources.UEPB;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_Topo
            // 
            panel_Topo.BackColor = Color.FromArgb(30, 31, 59);
            panel_Topo.BorderStyle = BorderStyle.FixedSingle;
            panel_Topo.Controls.Add(label1);
            panel_Topo.Controls.Add(iconPictureBox1);
            panel_Topo.Dock = DockStyle.Top;
            panel_Topo.Location = new Point(303, 0);
            panel_Topo.Name = "panel_Topo";
            panel_Topo.Size = new Size(1048, 125);
            panel_Topo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 38);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 1;
            label1.Text = "Seja Bem Vindo!";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(30, 31, 68);
            iconPictureBox1.ForeColor = SystemColors.ControlLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SmileWink;
            iconPictureBox1.IconColor = SystemColors.ControlLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new Point(0, 27);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(53, 53);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // tabControl_Centro
            // 
            tabControl_Centro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_Centro.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl_Centro.ItemSize = new Size(0, 35);
            tabControl_Centro.Location = new Point(303, 125);
            tabControl_Centro.Name = "tabControl_Centro";
            tabControl_Centro.SelectedIndex = 0;
            tabControl_Centro.ShowToolTips = true;
            tabControl_Centro.Size = new Size(1048, 638);
            tabControl_Centro.SizeMode = TabSizeMode.FillToRight;
            tabControl_Centro.TabIndex = 4;
            // 
            // form_Menu_Principal2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 763);
            Controls.Add(tabControl_Centro);
            Controls.Add(panel_Topo);
            Controls.Add(panel_Esquerdo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(4);
            Name = "form_Menu_Principal2";
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            panel_Esquerdo.ResumeLayout(false);
            panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Topo.ResumeLayout(false);
            panel_Topo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Esquerdo;
        private Panel panel_Logo;
        private FontAwesome.Sharp.IconButton IB_AULA;
        private FontAwesome.Sharp.IconButton IB_Teste;
        private FontAwesome.Sharp.IconButton IB_Atividades;
        private FontAwesome.Sharp.IconButton IB_NOTAS;
        private PictureBox pictureBox1;
        private Panel panel_Topo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private TabControl tabControl_Centro;
    }
}