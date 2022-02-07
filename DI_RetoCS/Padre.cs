using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_RetoCS
{
    public partial class Padre : Form
    {
        public Padre()
        {
            InitializeComponent();
        }
        //para que lo podamos ver en los demas formularios tenemos que poner esto
        public static Conectado f1 = new Conectado();
        private NoConectado f2 = new NoConectado();
        private Relaciones f3 = new Relaciones();
        private Informes f4 = new Informes();
        private JSON f5 = new JSON();

        private void Padre_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.menuStrip1.MdiWindowListItem = milista;
            f1.MdiParent = this;
            f2.MdiParent = this;
            f3.MdiParent = this;
            f4.MdiParent = this;
            f5.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f2.WindowState = FormWindowState.Maximized;
            f3.WindowState = FormWindowState.Maximized;
            f4.WindowState = FormWindowState.Maximized;
            f5.WindowState = FormWindowState.Maximized;
            f1.Show();
            f1.Activate();

        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.Activate();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            f3.Activate();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
            f4.Activate();
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Show();
            f5.Activate();
        }

        private void relacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
