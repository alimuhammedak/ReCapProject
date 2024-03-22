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
