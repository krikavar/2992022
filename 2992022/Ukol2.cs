using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2992022
{
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

        private void Ukol2_Load(object sender, EventArgs e)
        {
            Form Ukol2 = new Form();
            StreamReader ctu = new StreamReader((@"..\..\Znaky.dat"));
            listBox1.Text = ctu.ReadToEnd();
        }
    }
}
