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
    public partial class Conectado : Form
    {
        public Conectado()
        {
            InitializeComponent();
        }
        //private string sql;
        //private int cont;
        //private MiConexion Conexion = new MiConexion();
        //SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
        //Conexion.AbrirConexion();
        private MiConexion Conexion = new MiConexion();
        private string sql,sql1;
        private int resul,cont;
        private DataSet das1,das2;
        private SqlDataAdapter adap1,adap2;
        private void Form1_Load(object sender, EventArgs e)
        {

            sql = "select CodLoc from clientes";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            adap1 = new SqlDataAdapter(cmd);
            das1 = new DataSet();
            adap1.Fill(das1, "aaa");
            for (int i = 0; i < das1.Tables[0].Rows.Count - 1; i++)
            {
                comboBox3.Items.Add(das1.Tables[0].Rows[i][0]);
            }



            sql1 = "Select fecha from facturas";
            SqlCommand cmd1 = new SqlCommand(sql1, Conexion.pConexion);
            adap2 = new SqlDataAdapter(cmd1);
            das2 = new DataSet();
            adap2.Fill(das2, "bbb");
            for (int a = 0; a < das2.Tables[0].Rows.Count - 1; a++)
            {
                comboBox1.Items.Add(das2.Tables[0].Rows[a][0]);
                comboBox2.Items.Add(das2.Tables[0].Rows[a][0]);
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.AbrirConexion();
                label1.Text = "Conexion correcta";
                Conexion.CerrarConexion();
            }
            catch (Exception)
            {
                label1.Text = "error";
            }
        }

        private void Contar_Click(object sender, EventArgs e)
        {
            sql = "select count(*) from Facturas";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                resul = Convert.ToInt32(cmd.ExecuteScalar());
                label2.Text="Hay: " + resul+ " facturas";
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.ToString());
            }
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            sql = "Insert into clientes (CodCli,NombCli,Direccion,CP,CodLoc) ";
            sql += "values ('400','Aitor','Su casa','48006','07766')";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                resul = Convert.ToInt32(cmd.ExecuteNonQuery());
                label3.Text="Insertadas: " + resul + " filas.";
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            sql = "delete from clientes where CodCli='400'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                resul = Convert.ToInt32(cmd.ExecuteNonQuery());
                label4.Text="Borradas: " + resul + " filas.";
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void metadatos_Click(object sender, EventArgs e)
        {
            //METADATOS
            sql = "Select * from facturas";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            string acum = null;
            SqlDataReader dr;
            cont = 0;
            try
            {
                Conexion.AbrirConexion();
                dr = cmd.ExecuteReader();
                for (int x = 0; x <= dr.FieldCount - 1; x++)
                {
                    acum += dr.GetName(x) + " - " + dr.GetFieldType(x) + Environment.NewLine;
                }
                acum += new string('-', 30);  // en c# no existe strdup
                MessageBox.Show(acum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            sql = "update clientes set NombCli='ander'";
            sql += "where CodCli= 400";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                resul = Convert.ToInt32(cmd.ExecuteNonQuery());
               label5.Text="Actualizadas: " + resul + " filas.";
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            sql = "Select NombCli,Direccion as 'Direccion',CP as 'Codigo Postal'";
            sql += "from clientes where Codloc='"+comboBox3.Text+"' order by CodCli";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();

                listView1.Clear();
                listView1.GridLines = true;
                listView1.View = View.Details;
                // añadimos columnas al listview1
                listView1.Columns.Add("Nombre", 120, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(1), 160, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(2), 120, HorizontalAlignment.Right);

                while (dr.Read())
                {
                    //tener en cuenta el numero de columnas 
                    ListViewItem fila = new ListViewItem(dr.GetString(0));
                    fila.SubItems.Add(dr.GetString(1));
                    fila.SubItems.Add(dr.GetString(2));
                    listView1.Items.Add(fila);
                }
                Conexion.CerrarConexion();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            sql = "Select CodFac,fecha as 'Fecha',CodCli as 'codigo cliente' from facturas where fecha >= '"+comboBox1.Text+"' and fecha <='"+comboBox2.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();

                listView1.Clear();
                listView1.GridLines = true;
                listView1.View = View.Details;
                // añadimos columnas al listview1
                listView1.Columns.Add("codigo factura", 120, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(1), 160, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(2), 120, HorizontalAlignment.Right);

                while (dr.Read())
                {
                    //tener en cuenta el numero de columnas 
                    ListViewItem fila = new ListViewItem(Convert.ToString(dr.GetValue(0)));
                    fila.SubItems.Add(Convert.ToString(dr.GetDateTime(1).ToShortDateString()));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(2)));
                    listView1.Items.Add(fila);
                }
                Conexion.CerrarConexion();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        private void listar_Click(object sender, EventArgs e)
        {
            string acum = null;
            sql = "Select NombCli from clientes";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            SqlDataReader dr;
            cont = 0;
            try
            {
                Conexion.AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cont += 1;
                    acum += cont + "- " + dr.GetString(0) + Environment.NewLine;
                    if ((cont % 25) == 0)
                    {
                        MessageBox.Show(acum);
                        acum = null;
                    }
                }
                if (acum != null)
                {
                    MessageBox.Show(acum);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
    }
}
