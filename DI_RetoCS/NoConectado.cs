using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DI_RetoCS
{
    public partial class NoConectado : Form
    {
        public NoConectado()
        {
            InitializeComponent();
        }

        private string sql,sql1,sql2;
        private MiConexion Conexion = new MiConexion();
        private DataSet das1,das2;
        private SqlDataAdapter adap1,adap2,adap3,adap4;
        private void NoConectado_Load(object sender, EventArgs e)
        {
            sql = "select CodVend, NombVen,DirecVen,Telefono,Salario from Vendedores";
            SqlCommand cmd1 = new SqlCommand(sql, Conexion.pConexion);
            adap1 = new SqlDataAdapter(cmd1);
            das1 = new DataSet();
            adap1.Fill(das1, "aaa");
            dataGridView1.DataSource = das1.Tables[0];
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 160;

            SqlCommandBuilder cmb = new SqlCommandBuilder(adap1);

            das1.Tables[0].PrimaryKey = new DataColumn[] { das1.Tables[0].Columns["CodVend"] };

            sql1 = "Select CodCli from Clientes";
            SqlCommand cmd2 = new SqlCommand(sql1, Conexion.pConexion);
            adap2 = new SqlDataAdapter(cmd2);
            das2 = new DataSet();
            adap2.Fill(das2, "aaa");
            for (int i = 0; i < das2.Tables[0].Rows.Count - 1; i++)
            {
                comboBox1.Items.Add(das2.Tables[0].Rows[i][0]);
            }
        }
        private void Cargar_Click(object sender, EventArgs e)
        {
            das1.Tables[0].Clear();
            adap1.Fill(das1, "aaa");
            label1.Text = das1.Tables[0].Rows.Count + " filas.";
        }

        private void Guardarxml_Click(object sender, EventArgs e)
        {
            //los xmls se guardan en el /bin/debug (para comprobar si func
            das1.WriteXml("Vendedores.xml");
            das1.WriteXmlSchema("VendedorFormato.xml");
        }

        private void CargarXML_Click(object sender, EventArgs e)
        {
            //leer XML
            das1.Tables[0].Clear();
            das1.ReadXml("Vendedores.xml");
        }

        private void Updat_Click(object sender, EventArgs e)
        {
            try
            {
                adap1.Update(das1, "aaa");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void AniadirX_Click(object sender, EventArgs e)
        {
            das1.Tables[0].Rows[0][1] += "X";
        }

        private void BorrarLetra_Click(object sender, EventArgs e)
        {
            string aaa = Convert.ToString(das1.Tables[0].Rows[0][1]);
            das1.Tables[0].Rows[0][1] = aaa.Substring(0, aaa.Length - 1);
        }

        private void BorrarVen_Click(object sender, EventArgs e)
        {
            das1.Tables[0].Rows.Find(txtBorrar.Text).Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            //'Por si la celda está vacia...
            if (!Convert.IsDBNull(this.dataGridView1.CurrentRow.Cells[4].Value))
            {
                textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void buscarFila_Click(object sender, EventArgs e)
        {
            //ir a una fila
            int fila = Convert.ToInt32(this.txtFila.Text);
            fila = fila - 1;
            if (fila >= 0 && fila < das1.Tables[0].Rows.Count)
            {
                this.dataGridView1.Rows[fila].Selected = true;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[fila].Cells[0];
            }
        }

        private void BuscarNombre_Click(object sender, EventArgs e)
        {
            string nombre;
            string fila;
            // En Referencias, Agregar referencia, Microsoft.VisualBasic
            nombre =Interaction.InputBox("Introduce nombre de vendedor", "Proyecto DI", "");
            for (int x = 0; x <= das1.Tables[0].Rows.Count - 1; x = x + 1)
            {
                fila = Convert.ToString(das1.Tables[0].Rows[x][1]);
                if (fila.StartsWith(nombre))
                {
                    dataGridView1.Rows[x].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, x];
                    MessageBox.Show("Encontrado");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet das3 = new DataSet();
            sql = "Select distinct CodCli from Facturas where CodCli >=" + comboBox1.Text + "order by CodCli";
            SqlCommand cmd3 = new SqlCommand(sql, Conexion.pConexion);
            adap3 = new SqlDataAdapter(cmd3);
            adap3.Fill(das3, "ccc");
            string acum = null;
            int cont = 0;
            for (int i = 0; i < das3.Tables[0].Rows.Count; i++)
            {
                acum += das3.Tables[0].Rows[i][0].ToString() + " - " + calcular(Convert.ToInt32(das3.Tables[0].Rows[i][0])).ToString() + Environment.NewLine;
                cont += 1;
                if (cont == 10)
                {
                    break;
                }
            }
            MessageBox.Show(acum);
        }

        private double calcular(int a)
        {
            DataSet das4 = new DataSet();
            double total = 0;
            double aa, bb;
            String id = a.ToString();
            sql2 = "Select * from Facturas where CodCli=" + id;
            SqlCommand cmd4 = new SqlCommand(sql2, Conexion.pConexion);
            adap4 = new SqlDataAdapter(cmd4);
            adap4.Fill(das4, "ddd");
            for (int i = 0; i < das4.Tables[0].Rows.Count; i++)
            {
                aa = Convert.ToDouble(das4.Tables[0].Rows[i]["Importe"]);
                bb = Convert.ToDouble(das4.Tables[0].Rows[i]["GastoEnvio"]);
                total += aa + bb;
            }
            //MessageBox.Show(total.ToString());
            return total;
        }
    }
}
