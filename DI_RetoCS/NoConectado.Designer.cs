
namespace DI_RetoCS
{
    partial class NoConectado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardarxml = new System.Windows.Forms.Button();
            this.CargarXML = new System.Windows.Forms.Button();
            this.Updat = new System.Windows.Forms.Button();
            this.AniadirX = new System.Windows.Forms.Button();
            this.BorrarLetra = new System.Windows.Forms.Button();
            this.BorrarVen = new System.Windows.Forms.Button();
            this.txtBorrar = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buscarFila = new System.Windows.Forms.Button();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.BuscarNombre = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(40, 30);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(75, 23);
            this.Cargar.TabIndex = 1;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Guardarxml
            // 
            this.Guardarxml.Location = new System.Drawing.Point(40, 74);
            this.Guardarxml.Name = "Guardarxml";
            this.Guardarxml.Size = new System.Drawing.Size(75, 36);
            this.Guardarxml.TabIndex = 3;
            this.Guardarxml.Text = "Guardar XML";
            this.Guardarxml.UseVisualStyleBackColor = true;
            this.Guardarxml.Click += new System.EventHandler(this.Guardarxml_Click);
            // 
            // CargarXML
            // 
            this.CargarXML.Location = new System.Drawing.Point(40, 128);
            this.CargarXML.Name = "CargarXML";
            this.CargarXML.Size = new System.Drawing.Size(75, 23);
            this.CargarXML.TabIndex = 4;
            this.CargarXML.Text = "Cargar XML";
            this.CargarXML.UseVisualStyleBackColor = true;
            this.CargarXML.Click += new System.EventHandler(this.CargarXML_Click);
            // 
            // Updat
            // 
            this.Updat.Location = new System.Drawing.Point(40, 172);
            this.Updat.Name = "Updat";
            this.Updat.Size = new System.Drawing.Size(75, 23);
            this.Updat.TabIndex = 5;
            this.Updat.Text = "Update";
            this.Updat.UseVisualStyleBackColor = true;
            this.Updat.Click += new System.EventHandler(this.Updat_Click);
            // 
            // AniadirX
            // 
            this.AniadirX.Location = new System.Drawing.Point(235, 30);
            this.AniadirX.Name = "AniadirX";
            this.AniadirX.Size = new System.Drawing.Size(75, 23);
            this.AniadirX.TabIndex = 6;
            this.AniadirX.Text = "Añadir X";
            this.AniadirX.UseVisualStyleBackColor = true;
            this.AniadirX.Click += new System.EventHandler(this.AniadirX_Click);
            // 
            // BorrarLetra
            // 
            this.BorrarLetra.Location = new System.Drawing.Point(235, 74);
            this.BorrarLetra.Name = "BorrarLetra";
            this.BorrarLetra.Size = new System.Drawing.Size(107, 36);
            this.BorrarLetra.TabIndex = 7;
            this.BorrarLetra.Text = "Borrar ultima letra de direccion";
            this.BorrarLetra.UseVisualStyleBackColor = true;
            this.BorrarLetra.Click += new System.EventHandler(this.BorrarLetra_Click);
            // 
            // BorrarVen
            // 
            this.BorrarVen.Location = new System.Drawing.Point(235, 127);
            this.BorrarVen.Name = "BorrarVen";
            this.BorrarVen.Size = new System.Drawing.Size(107, 23);
            this.BorrarVen.TabIndex = 8;
            this.BorrarVen.Text = "Borrar Vendedor";
            this.BorrarVen.UseVisualStyleBackColor = true;
            this.BorrarVen.Click += new System.EventHandler(this.BorrarVen_Click);
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(348, 129);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(100, 20);
            this.txtBorrar.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 11;
            // 
            // buscarFila
            // 
            this.buscarFila.Location = new System.Drawing.Point(477, 30);
            this.buscarFila.Name = "buscarFila";
            this.buscarFila.Size = new System.Drawing.Size(75, 23);
            this.buscarFila.TabIndex = 12;
            this.buscarFila.Text = "Buscar fila";
            this.buscarFila.UseVisualStyleBackColor = true;
            this.buscarFila.Click += new System.EventHandler(this.buscarFila_Click);
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(559, 32);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(100, 20);
            this.txtFila.TabIndex = 13;
            // 
            // BuscarNombre
            // 
            this.BuscarNombre.Location = new System.Drawing.Point(477, 81);
            this.BuscarNombre.Name = "BuscarNombre";
            this.BuscarNombre.Size = new System.Drawing.Size(121, 23);
            this.BuscarNombre.TabIndex = 14;
            this.BuscarNombre.Text = "Buscar por nombre";
            this.BuscarNombre.UseVisualStyleBackColor = true;
            this.BuscarNombre.Click += new System.EventHandler(this.BuscarNombre_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(477, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NoConectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BuscarNombre);
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.buscarFila);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.BorrarVen);
            this.Controls.Add(this.BorrarLetra);
            this.Controls.Add(this.AniadirX);
            this.Controls.Add(this.Updat);
            this.Controls.Add(this.CargarXML);
            this.Controls.Add(this.Guardarxml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NoConectado";
            this.Text = "NoConectado";
            this.Load += new System.EventHandler(this.NoConectado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardarxml;
        private System.Windows.Forms.Button CargarXML;
        private System.Windows.Forms.Button Updat;
        private System.Windows.Forms.Button AniadirX;
        private System.Windows.Forms.Button BorrarLetra;
        private System.Windows.Forms.Button BorrarVen;
        private System.Windows.Forms.TextBox txtBorrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buscarFila;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Button BuscarNombre;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}