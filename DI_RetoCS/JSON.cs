using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DI_RetoCS
{
    public partial class JSON : Form
    {
        public JSON()
        {
            InitializeComponent();
        }

        private void JSON_Load(object sender, EventArgs e)
        {
            string filejson = File.ReadAllText(@"json/albums.json");
            //Coge todo lo que hay en el string como texto plano, ignorando caracteres escape y otros simbolos
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            dataGridView1.DataSource = dt;
        }

    }
}
