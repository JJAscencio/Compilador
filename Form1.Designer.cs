namespace compilador1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.codigos = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.compilarButton = new System.Windows.Forms.PictureBox();
            this.guardarButton = new System.Windows.Forms.PictureBox();
            this.abrirButton = new System.Windows.Forms.PictureBox();
            this.txtSalida = new System.Windows.Forms.RichTextBox();
            this.dataLexemas = new System.Windows.Forms.DataGridView();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compilarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrirButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLexemas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.codigos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.compilarButton);
            this.panel1.Controls.Add(this.guardarButton);
            this.panel1.Controls.Add(this.abrirButton);
            this.panel1.Controls.Add(this.txtSalida);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 507);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // codigos
            // 
            this.codigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigos.Location = new System.Drawing.Point(7, 80);
            this.codigos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigos.Name = "codigos";
            this.codigos.Size = new System.Drawing.Size(687, 179);
            this.codigos.TabIndex = 14;
            this.codigos.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(644, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Home";
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 69);
            this.label1.TabIndex = 9;
            this.label1.Text = "Compilador v1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // compilarButton
            // 
            this.compilarButton.BackColor = System.Drawing.Color.Transparent;
            this.compilarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compilarButton.Image = ((System.Drawing.Image)(resources.GetObject("compilarButton.Image")));
            this.compilarButton.Location = new System.Drawing.Point(644, 267);
            this.compilarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compilarButton.Name = "compilarButton";
            this.compilarButton.Size = new System.Drawing.Size(48, 42);
            this.compilarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compilarButton.TabIndex = 7;
            this.compilarButton.TabStop = false;
            this.compilarButton.Click += new System.EventHandler(this.CompilarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.Color.Transparent;
            this.guardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarButton.Image")));
            this.guardarButton.Location = new System.Drawing.Point(4, 31);
            this.guardarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(51, 42);
            this.guardarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardarButton.TabIndex = 5;
            this.guardarButton.TabStop = false;
            this.guardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // abrirButton
            // 
            this.abrirButton.BackColor = System.Drawing.Color.Transparent;
            this.abrirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abrirButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirButton.Image")));
            this.abrirButton.Location = new System.Drawing.Point(63, 31);
            this.abrirButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Size = new System.Drawing.Size(44, 42);
            this.abrirButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.abrirButton.TabIndex = 4;
            this.abrirButton.TabStop = false;
            this.abrirButton.Click += new System.EventHandler(this.AbrirButton_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(4, 316);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(687, 184);
            this.txtSalida.TabIndex = 2;
            this.txtSalida.Text = "";
            // 
            // dataLexemas
            // 
            this.dataLexemas.AllowUserToDeleteRows = false;
            this.dataLexemas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataLexemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLexemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLexemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexema,
            this.Token});
            this.dataLexemas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataLexemas.Location = new System.Drawing.Point(728, 95);
            this.dataLexemas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataLexemas.Name = "dataLexemas";
            this.dataLexemas.ReadOnly = true;
            this.dataLexemas.RowTemplate.Height = 24;
            this.dataLexemas.Size = new System.Drawing.Size(232, 427);
            this.dataLexemas.TabIndex = 14;
            this.dataLexemas.Visible = false;
            this.dataLexemas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLexemas_CellContentClick);
            // 
            // Lexema
            // 
            this.Lexema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.ReadOnly = true;
            this.Lexema.Width = 86;
            // 
            // Token
            // 
            this.Token.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.Width = 77;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 632);
            this.Controls.Add(this.dataLexemas);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Compilador v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compilarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrirButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLexemas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox abrirButton;
        private System.Windows.Forms.RichTextBox txtSalida;
        private System.Windows.Forms.PictureBox guardarButton;
        private System.Windows.Forms.PictureBox compilarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox codigos;
        private System.Windows.Forms.DataGridView dataLexemas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.Timer timer1;
    }
}

