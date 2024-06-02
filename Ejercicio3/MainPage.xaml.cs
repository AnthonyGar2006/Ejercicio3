namespace Ejercicio3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double Nota1 = Convert.ToDouble(txtN1.Text);
            double Nota2 = Convert.ToDouble(txtN2.Text);
            double Nota3 = Convert.ToDouble(txtN3.Text);
            double Nota4 = Convert.ToDouble(txtN4.Text);
            double Nota5 = Convert.ToDouble(txtN5.Text);

            // Calcular el promedio
            double promedio = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5;

            // Mostrar el promedio en el label
            lblPromedio.Text = $"El promedio es: {promedio:F2}";
        }
    }

}
