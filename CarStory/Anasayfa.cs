using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace CarStory
{
    public partial class Anasayfa : Form
    {
        
        public Anasayfa()
        {
            InitializeComponent();
            
        }

        private void btnArabaStore_Click(object sender, EventArgs e)
        {
            var frmCars = new frmCars();
            frmCars.Show();
            this.Hide();
        }
    }
}
