namespace ADMIN_AULAS.Menu
{
    partial class form_Notas
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
            listView1 = new ListView();
            MATERIA = new ColumnHeader();
            PROFESSOR = new ColumnHeader();
            IC_ADICIONAR = new FontAwesome.Sharp.IconButton();
            IC_DELETAR = new FontAwesome.Sharp.IconButton();
            NOTA1 = new ColumnHeader();
            NOTA2 = new ColumnHeader();
            MEDIA = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.Snow;
            listView1.BorderStyle = BorderStyle.None;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { MATERIA, PROFESSOR, NOTA1, NOTA2, MEDIA });
            listView1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(56, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(887, 503);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // MATERIA
            // 
            MATERIA.Text = "MATERIA";
            MATERIA.Width = 300;
            // 
            // PROFESSOR
            // 
            PROFESSOR.Text = "PROFESSOR";
            PROFESSOR.Width = 200;
            // 
            // IC_ADICIONAR
            // 
            IC_ADICIONAR.BackColor = Color.DarkKhaki;
            IC_ADICIONAR.FlatStyle = FlatStyle.Flat;
            IC_ADICIONAR.Font = new Font("Stencil", 13F, FontStyle.Bold, GraphicsUnit.Point);
            IC_ADICIONAR.ForeColor = SystemColors.ActiveCaptionText;
            IC_ADICIONAR.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            IC_ADICIONAR.IconColor = Color.Black;
            IC_ADICIONAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IC_ADICIONAR.ImageAlign = ContentAlignment.MiddleLeft;
            IC_ADICIONAR.Location = new Point(56, 561);
            IC_ADICIONAR.Name = "IC_ADICIONAR";
            IC_ADICIONAR.Size = new Size(215, 77);
            IC_ADICIONAR.TabIndex = 1;
            IC_ADICIONAR.Text = "    ADICIONAR";
            IC_ADICIONAR.UseVisualStyleBackColor = false;
            // 
            // IC_DELETAR
            // 
            IC_DELETAR.BackColor = Color.HotPink;
            IC_DELETAR.FlatStyle = FlatStyle.Flat;
            IC_DELETAR.Font = new Font("Stencil", 13F, FontStyle.Bold, GraphicsUnit.Point);
            IC_DELETAR.ForeColor = SystemColors.ActiveCaptionText;
            IC_DELETAR.IconChar = FontAwesome.Sharp.IconChar.PlantWilt;
            IC_DELETAR.IconColor = Color.Black;
            IC_DELETAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IC_DELETAR.ImageAlign = ContentAlignment.MiddleLeft;
            IC_DELETAR.Location = new Point(728, 561);
            IC_DELETAR.Name = "IC_DELETAR";
            IC_DELETAR.Size = new Size(215, 77);
            IC_DELETAR.TabIndex = 2;
            IC_DELETAR.Text = "    DELETAR";
            IC_DELETAR.TextAlign = ContentAlignment.MiddleLeft;
            IC_DELETAR.UseVisualStyleBackColor = false;
            // 
            // NOTA1
            // 
            NOTA1.Text = "NOTA1";
            NOTA1.Width = 100;
            // 
            // NOTA2
            // 
            NOTA2.Text = "NOTA2";
            NOTA2.Width = 100;
            // 
            // MEDIA
            // 
            MEDIA.Text = "MEDIA";
            MEDIA.Width = 100;
            // 
            // form_Notas
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            BackColor = Color.Transparent;
            Controls.Add(IC_DELETAR);
            Controls.Add(IC_ADICIONAR);
            Controls.Add(listView1);
            ForeColor = SystemColors.GradientActiveCaption;
            Name = "form_Notas";
            Size = new Size(1048, 638);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader MATERIA;
        private ColumnHeader PROFESSOR;
        private FontAwesome.Sharp.IconButton IC_ADICIONAR;
        private FontAwesome.Sharp.IconButton IC_DELETAR;
        private ColumnHeader NOTA1;
        private ColumnHeader NOTA2;
        private ColumnHeader MEDIA;
    }
}


