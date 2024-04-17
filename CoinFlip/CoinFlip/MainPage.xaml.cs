namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void GirarMoeda(object sender, EventArgs e)
        {
            Random Lado = new Random();
            int SelecaoLado = Lado.Next(2);

            if(SelecaoLado == 0)
            {
                CaraCoroa.Text = "Cara";
            }
            else
            {
                CaraCoroa.Text = "Coroa";
            }

            if (Escolha.SelectedIndex == SelecaoLado)
            {
                ApostaCerta.Text = "Sua aposta está certa!";
            }
            else
            {
                ApostaCerta.Text = "Sua aposta está errada!";
            }


        }
    }

}
