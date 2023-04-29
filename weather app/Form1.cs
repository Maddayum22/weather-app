namespace weather_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var query = weatherInput.Text;
            var weatherClass = new getWeatherData();
            var weatherData = await weatherClass.GetWeatherAsync(query);

            if (weatherData != null)
            {
                weatherOutput.Text = weatherData.Current.Temperature.ToString();
            }
            else
            {
                weatherOutput.Text = "Something went wrong, have you spelled the city name correctly?";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void weatherInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}