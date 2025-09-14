namespace appprueba
{
    public partial class MainPage : ContentPage
    {
        float c = 0, f = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            if (float.TryParse(txtcelcius.Text, out float c))
            {
                float f = (float)(c * 1.8 + 32);

                lblresultado.Text = $"Resultado: {f} °F";
            }
            else
            {
                lblresultado.Text = "Por favor ingresa un número válido.";
            }
        }
    }

}
