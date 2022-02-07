using Microsoft.Reporting.WinForms;
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
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }
        private MiConexion Conexion = new MiConexion();
        private string sql;
        

        private void Informes_Load(object sender, EventArgs e)
        {
            //Agregar en el proyecto primero el Conjunto de datos(meter la bd que es y arrastrar la tabla) y luego el Asistente para informes
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Peliculas' Puede moverla o quitarla según sea necesario.
            this.PeliculasTableAdapter.Fill(this.DataSet1.Peliculas);

            this.reportViewer1.RefreshReport();

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
                Conexion.AbrirConexion();
                sql = "Select * from peliculas where pais ='"+textBox1.Text.ToUpper()+"'";
                SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
                SqlDataAdapter adap1= new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap1.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
                Conexion.CerrarConexion();
               
              
            }

        private void Transacion_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            Conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaccion;

            //inicia la transaccion
            transaccion = Conexion.pConexion.BeginTransaction();
            cmd.Connection = Conexion.pConexion;
            cmd.Transaction = transaccion;

            try
            {
                cmd.CommandText = "SELECT Precio FROM Peliculas WHERE CodPelicula = 101";
                resultado = Convert.ToDouble(cmd.ExecuteScalar());
                MessageBox.Show(resultado.ToString(), "inicial");

                cmd.CommandText = "UPDATE Peliculas SET Precio = Precio + 5  WHERE CodPelicula = 101";
                cmd.ExecuteNonQuery();

               
                cmd.CommandText = "UPDATE Productos SET UnitPrice = UnitPrice + 3.99  WHERE ProductID = 4";
                cmd.ExecuteNonQuery();

                transaccion.Commit();

            }
            catch (Exception)
            {
                transaccion.Rollback();
                MessageBox.Show("Se ha producido un error");

                cmd.CommandText = "SELECT Precio FROM Peliculas WHERE CodPelicula = 101";
                resultado = Convert.ToDouble(cmd.ExecuteScalar());
                MessageBox.Show(resultado.ToString(), "Compruebo si es igual al valor inicial");
            }
        }
    }
    }

