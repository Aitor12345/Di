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
    public partial class Relaciones : Form
    {
        public Relaciones()
        {
            InitializeComponent();
        }
        private MiConexion Conexion = new MiConexion();
        private SqlDataAdapter adapCliente, adapFacturas;
        DataSet das1;

        private void Borrar_Click(object sender, EventArgs e)
        {
            int borrar = 0;
            borrar = Convert.ToInt32(Interaction.InputBox("Escribe el CodCli", "Borrar por CodCli", ""));
            das1.Tables[0].Rows.Find(borrar).Delete();
        }

        private void Relaciones_Load(object sender, EventArgs e)
        {
            das1 = new DataSet();  
            try
            {
                string sql = "select * from Clientes";
                string sql1 = "select * from Facturas";
                //'Hay un solo das1 y dos adaptadores
                adapCliente = new SqlDataAdapter(sql, Conexion.pConexion);
                adapCliente.Fill(das1, "padre");
                adapFacturas = new SqlDataAdapter(sql1, Conexion.pConexion);
                adapFacturas.Fill(das1, "hijo");

                //'Creo la relacion en el das1 
                DataColumn a, b;
                a = das1.Tables["padre"].Columns["CodCli"];
                b = das1.Tables["hijo"].Columns["CodCli"];
                das1.Relations.Add("mirelacion", a, b);
                //'visualizamos
                DataGridView1.DataSource = das1;
                DataGridView1.DataMember = "padre";
                DataGridView2.DataSource = das1;
                DataGridView2.DataMember = "padre.mirelacion";

                //'crear automaticamente la sql para update -
                SqlCommandBuilder cmb1 = new SqlCommandBuilder(adapCliente);
                SqlCommandBuilder cmb2 = new SqlCommandBuilder(adapFacturas);

                das1.Tables[0].PrimaryKey = new DataColumn[] { das1.Tables[0].Columns["CodCli"] };

            }
            catch (Exception)
            {

            }
        }


    }
}
