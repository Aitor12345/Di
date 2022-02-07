
using System;

namespace DI_RetoCS
{
    partial class Conectado
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Contar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.actualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.listar = new System.Windows.Forms.Button();
            this.metadatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Contar
            // 
            this.Contar.Location = new System.Drawing.Point(31, 89);
            this.Contar.Name = "Contar";
            this.Contar.Size = new System.Drawing.Size(107, 23);
            this.Contar.TabIndex = 2;
            this.Contar.Text = "Contar Facturas";
            this.Contar.UseVisualStyleBackColor = true;
            this.Contar.Click += new System.EventHandler(this.Contar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(31, 136);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(107, 23);
            this.insertar.TabIndex = 4;
            this.insertar.Text = "inserta un cliente";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(31, 184);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(107, 23);
            this.Borrar.TabIndex = 6;
            this.Borrar.Text = "borrar un cliente";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(31, 233);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(107, 23);
            this.actualizar.TabIndex = 8;
            this.actualizar.Text = "actualiza un cliente";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(31, 283);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(107, 23);
            this.mostrar.TabIndex = 10;
            this.mostrar.Text = "Mostrar clientes";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(251, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 182);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(349, 331);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(75, 23);
            this.fecha.TabIndex = 17;
            this.fecha.Text = "buscar";
            this.fecha.UseVisualStyleBackColor = true;
            this.fecha.Click += new System.EventHandler(this.fecha_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 331);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(144, 283);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(194, 379);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(149, 23);
            this.listar.TabIndex = 21;
            this.listar.Text = "Listar Clientes (25*25)";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // metadatos
            // 
            this.metadatos.Location = new System.Drawing.Point(31, 379);
            this.metadatos.Name = "metadatos";
            this.metadatos.Size = new System.Drawing.Size(127, 23);
            this.metadatos.TabIndex = 22;
            this.metadatos.Text = "metadatos tabla factura";
            this.metadatos.UseVisualStyleBackColor = true;
            this.metadatos.Click += new System.EventHandler(this.metadatos_Click);
            // 
            // Conectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.metadatos);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Conectado";
            this.Text = "Conectado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Contar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button fecha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.Button metadatos;
    }
}