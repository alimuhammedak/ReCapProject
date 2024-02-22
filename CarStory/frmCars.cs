using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace CarStory
{
    public partial class frmCars : Form
    {
        private CarManager _carManager;
        public frmCars()
        {
            InitializeComponent();
            _carManager = new CarManager(new EfCarDal());
        }

        private void frmCars_Load(object sender, EventArgs eventArgs)
        {
            //    var cars = _carManager.GetAllAsync().Result;
            //    foreach (var car in cars)
            //    {
            //        var carIdMod = (car.CarId)%5;
            //        var x = 50;
            //        var button = new Button();
            //        button.Location = new Point((carIdMod==0)?10+x:x, 61);
            //        button.Name = $"btn{car.CarId}_{car.Description}";

            //        button.Size = new Size((50), 50);
            //        button.TabIndex = 0;
            //        button.Text = car.Description;
            //        button.UseVisualStyleBackColor = true;
            //    }
        }
    }
}
