namespace proyecto_610
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BSetNumColsReferencias = new System.Windows.Forms.Button();
            this.TxtNumColsReferencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BMarcos = new System.Windows.Forms.Button();
            this.BFerences = new System.Windows.Forms.Button();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.TxtMarco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRendimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearAll = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.RRJ = new System.Windows.Forms.RadioButton();
            this.ROPTIMO = new System.Windows.Forms.RadioButton();
            this.RFIFO = new System.Windows.Forms.RadioButton();
            this.RNRU = new System.Windows.Forms.RadioButton();
            this.R2OP = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tabla1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.BSetNumColsReferencias);
            this.groupBox1.Controls.Add(this.TxtNumColsReferencias);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BMarcos);
            this.groupBox1.Controls.Add(this.BFerences);
            this.groupBox1.Controls.Add(this.TxtReferencia);
            this.groupBox1.Controls.Add(this.TxtMarco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(515, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programas";
            // 
            // BSetNumColsReferencias
            // 
            this.BSetNumColsReferencias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSetNumColsReferencias.BackgroundImage")));
            this.BSetNumColsReferencias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BSetNumColsReferencias.Location = new System.Drawing.Point(221, 22);
            this.BSetNumColsReferencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BSetNumColsReferencias.Name = "BSetNumColsReferencias";
            this.BSetNumColsReferencias.Size = new System.Drawing.Size(109, 28);
            this.BSetNumColsReferencias.TabIndex = 9;
            this.BSetNumColsReferencias.Text = "Guardar L\'s";
            this.BSetNumColsReferencias.UseVisualStyleBackColor = true;
            this.BSetNumColsReferencias.Click += new System.EventHandler(this.BSetNumColsReferencias_Click);
            // 
            // TxtNumColsReferencias
            // 
            this.TxtNumColsReferencias.Location = new System.Drawing.Point(147, 25);
            this.TxtNumColsReferencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNumColsReferencias.Name = "TxtNumColsReferencias";
            this.TxtNumColsReferencias.Size = new System.Drawing.Size(67, 22);
            this.TxtNumColsReferencias.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(7, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de Ejecución:";
            // 
            // BMarcos
            // 
            this.BMarcos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMarcos.BackgroundImage")));
            this.BMarcos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BMarcos.Location = new System.Drawing.Point(219, 78);
            this.BMarcos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BMarcos.Name = "BMarcos";
            this.BMarcos.Size = new System.Drawing.Size(109, 23);
            this.BMarcos.TabIndex = 6;
            this.BMarcos.Text = "Guardar Mc\'s";
            this.BMarcos.UseVisualStyleBackColor = true;
            this.BMarcos.Click += new System.EventHandler(this.BMarcos_Click);
            // 
            // BFerences
            // 
            this.BFerences.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BFerences.BackgroundImage")));
            this.BFerences.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BFerences.Location = new System.Drawing.Point(220, 123);
            this.BFerences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BFerences.Name = "BFerences";
            this.BFerences.Size = new System.Drawing.Size(109, 23);
            this.BFerences.TabIndex = 5;
            this.BFerences.Text = "Guardar RF\'s";
            this.BFerences.UseVisualStyleBackColor = true;
            this.BFerences.Click += new System.EventHandler(this.BFerences_Click);
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Location = new System.Drawing.Point(148, 123);
            this.TxtReferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(67, 22);
            this.TxtReferencia.TabIndex = 4;
            // 
            // TxtMarco
            // 
            this.TxtMarco.Location = new System.Drawing.Point(147, 78);
            this.TxtMarco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMarco.Name = "TxtMarco";
            this.TxtMarco.Size = new System.Drawing.Size(67, 22);
            this.TxtMarco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad Marcos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(5, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Referencias:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.textRendimiento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.clearAll);
            this.groupBox2.Controls.Add(this.Limpiar);
            this.groupBox2.Controls.Add(this.RRJ);
            this.groupBox2.Controls.Add(this.ROPTIMO);
            this.groupBox2.Controls.Add(this.RFIFO);
            this.groupBox2.Controls.Add(this.RNRU);
            this.groupBox2.Controls.Add(this.R2OP);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(533, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(532, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algoritmos ";
            // 
            // textRendimiento
            // 
            this.textRendimiento.Location = new System.Drawing.Point(119, 122);
            this.textRendimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRendimiento.Name = "textRendimiento";
            this.textRendimiento.Size = new System.Drawing.Size(132, 22);
            this.textRendimiento.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rendimiento:";
            // 
            // clearAll
            // 
            this.clearAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearAll.BackgroundImage")));
            this.clearAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearAll.Location = new System.Drawing.Point(425, 22);
            this.clearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(75, 25);
            this.clearAll.TabIndex = 7;
            this.clearAll.Text = "Vaciar";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Limpiar.BackgroundImage")));
            this.Limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpiar.Location = new System.Drawing.Point(425, 73);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 27);
            this.Limpiar.TabIndex = 6;
            this.Limpiar.Text = "Limpiar Referencias";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // RRJ
            // 
            this.RRJ.AutoSize = true;
            this.RRJ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RRJ.BackgroundImage")));
            this.RRJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RRJ.Location = new System.Drawing.Point(315, 27);
            this.RRJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RRJ.Name = "RRJ";
            this.RRJ.Size = new System.Drawing.Size(60, 20);
            this.RRJ.TabIndex = 5;
            this.RRJ.TabStop = true;
            this.RRJ.Text = "Reloj";
            this.RRJ.UseVisualStyleBackColor = true;
            // 
            // ROPTIMO
            // 
            this.ROPTIMO.AutoSize = true;
            this.ROPTIMO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ROPTIMO.BackgroundImage")));
            this.ROPTIMO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ROPTIMO.Location = new System.Drawing.Point(187, 81);
            this.ROPTIMO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ROPTIMO.Name = "ROPTIMO";
            this.ROPTIMO.Size = new System.Drawing.Size(71, 20);
            this.ROPTIMO.TabIndex = 4;
            this.ROPTIMO.TabStop = true;
            this.ROPTIMO.Text = "Optimo";
            this.ROPTIMO.UseVisualStyleBackColor = true;
            // 
            // RFIFO
            // 
            this.RFIFO.AutoSize = true;
            this.RFIFO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RFIFO.BackgroundImage")));
            this.RFIFO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RFIFO.Location = new System.Drawing.Point(19, 81);
            this.RFIFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RFIFO.Name = "RFIFO";
            this.RFIFO.Size = new System.Drawing.Size(57, 20);
            this.RFIFO.TabIndex = 3;
            this.RFIFO.TabStop = true;
            this.RFIFO.Text = "FIFO";
            this.RFIFO.UseVisualStyleBackColor = true;
            // 
            // RNRU
            // 
            this.RNRU.AutoSize = true;
            this.RNRU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RNRU.BackgroundImage")));
            this.RNRU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RNRU.Location = new System.Drawing.Point(187, 27);
            this.RNRU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RNRU.Name = "RNRU";
            this.RNRU.Size = new System.Drawing.Size(58, 20);
            this.RNRU.TabIndex = 2;
            this.RNRU.TabStop = true;
            this.RNRU.Text = "NRU";
            this.RNRU.UseVisualStyleBackColor = true;
            // 
            // R2OP
            // 
            this.R2OP.AutoSize = true;
            this.R2OP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.R2OP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("R2OP.BackgroundImage")));
            this.R2OP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.R2OP.Location = new System.Drawing.Point(19, 27);
            this.R2OP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R2OP.Name = "R2OP";
            this.R2OP.Size = new System.Drawing.Size(112, 20);
            this.R2OP.TabIndex = 1;
            this.R2OP.TabStop = true;
            this.R2OP.Text = "2 Oportunidad";
            this.R2OP.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(425, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.Tabla1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(13, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1059, 378);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // Tabla1
            // 
            this.Tabla1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.Tabla1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.Tabla1.Location = new System.Drawing.Point(5, 23);
            this.Tabla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tabla1.Name = "Tabla1";
            this.Tabla1.RowHeadersWidth = 51;
            this.Tabla1.RowTemplate.Height = 24;
            this.Tabla1.Size = new System.Drawing.Size(1047, 338);
            this.Tabla1.TabIndex = 0;
            this.Tabla1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla1_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 578);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Tabla1;
        private System.Windows.Forms.TextBox TxtMarco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RRJ;
        private System.Windows.Forms.RadioButton ROPTIMO;
        private System.Windows.Forms.RadioButton RFIFO;
        private System.Windows.Forms.RadioButton RNRU;
        private System.Windows.Forms.RadioButton R2OP;
        private System.Windows.Forms.Button BMarcos;
        private System.Windows.Forms.Button BFerences;
        private System.Windows.Forms.Button BSetNumColsReferencias;
        private System.Windows.Forms.TextBox TxtNumColsReferencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.TextBox textRendimiento;
        private System.Windows.Forms.Label label4;
    }
}

