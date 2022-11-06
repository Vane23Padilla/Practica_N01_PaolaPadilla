namespace Ejercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hora 
            label_Hora.Text = DateTime.Now.ToLongTimeString();
            //Fecha
            label_Fecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}