using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSchool
{
    public partial class manageFullMix : Form
    {
        public manageFullMix()
        {
            InitializeComponent();
        }
        fullMix fullMix = new fullMix();
        void reload()
        {
            dataGridView1.DataSource = fullMix.getAllFullMix();
        }

        private void manageFullMix_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
