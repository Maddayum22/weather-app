using System.Net;
using System.Windows.Forms;

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

            if (weatherData != null && query.Length > 0)
            {
                city.Text = query;
                temperatureOutput.Text = weatherData.Current?.Temperature.ToString();
                weatherTypeOutput.Text = weatherData.Current?.Weather_descriptions[0];
                using (var client = new WebClient())
                {
                    var url = weatherData.Current?.Weather_icons?[0];
                    var stream = client.OpenRead(url!);
                    var image = Image.FromStream(stream);
                    weatherPic.Image = image;
                }
            }
            else
            {
                errorText.Text = "Something went wrong, have you spelled the city name correctly?";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void weatherInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }
    }
}