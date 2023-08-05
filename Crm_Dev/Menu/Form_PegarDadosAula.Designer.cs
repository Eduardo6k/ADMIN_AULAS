namespace Crm_Dev.Menu
{
    partial class Form_PegarDadosAula
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            getMat = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "MATERIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 98);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 1;
            label2.Text = "PROFESSOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 176);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 2;
            label3.Text = "DIA DA SEMANA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 240);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 3;
            label4.Text = "HORA";
            // 
            // getMat
            // 
            getMat.BorderStyle = BorderStyle.FixedSingle;
            getMat.Location = new Point(268, 36);
            getMat.Name = "getMat";
            getMat.Size = new Size(179, 27);
            getMat.TabIndex = 4;
            getMat.KeyUp += getMat_KeyUp;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(268, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 5;
            textBox2.KeyUp += textBox2_KeyUp;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(268, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 27);
            textBox3.TabIndex = 6;
            textBox3.KeyUp += textBox3_KeyUp;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(661, 374);
            button1.Name = "button1";
            button1.Size = new Size(161, 42);
            button1.TabIndex = 8;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox4.Location = new Point(268, 244);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(42, 27);
            maskedTextBox4.TabIndex = 9;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            maskedTextBox4.KeyUp += maskedTextBox4_KeyUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = ADMIN_AULAS.Properties.Resources.UEPB;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(552, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(455, 374);
            button2.Name = "button2";
            button2.Size = new Size(161, 42);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form_PegarDadosAula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(834, 447);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(maskedTextBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(getMat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_PegarDadosAula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_PegarDadosAula";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox getMat;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private MaskedTextBox maskedTextBox4;
        private PictureBox pictureBox1;
        private Button button2;
    }
}