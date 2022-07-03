using RestSharp;
using System;
using System.IO;
using System.Net;
using System.Web.UI;


namespace BMI_Web_Form
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void soapBMIButton_Click(object sender, EventArgs e)
        {
            ServiceReferenceSoap.Service1Client myPxy = new ServiceReferenceSoap.Service1Client();

            int height = Convert.ToInt32(this.height.Text);
            int weight = Convert.ToInt32(this.weight.Text);
            int BMI = (myPxy.calculateBMI(height, weight));

            this.soapBMILabel.Text = BMI.ToString();
            this.soapHealthIndicatorLabel.Text = myPxy.getHealthIndicator(BMI);
        }

        protected void restBMIButton_Click(object sender, EventArgs e)
        {

            //Uri baseUrl = new Uri("http://localhost:54845/Service1.svc/");
            int height = Convert.ToInt32(this.height.Text);
            int weight = Convert.ToInt32(this.weight.Text);

            string url = @"http://localhost:54845/Service1.svc/calculateBMI?height=" + this.height.Text + "&weight=" + this.weight.Text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseReader = reader.ReadToEnd();

            this.bmiRestLabel.Text = responseReader.Replace("/", "");
            string BMI = this.bmiRestLabel.Text;

            url = @"http://localhost:54845/Service1.svc/getHealthIndicator?BMI" + "&BMI=" + this.bmiRestLabel.Text;

            request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            response = request.GetResponse();
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            responseReader = reader.ReadToEnd();

            this.healthIndicatorRestLabel.Text = responseReader.Replace("/", "");

        }




    }
}