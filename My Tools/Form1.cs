using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;

namespace My_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BeautifyJSON(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(jsonInputuc1.GetValues))
            {

                JToken JSONInputObject = JToken.Parse(jsonInputuc1.GetValues);

                JToken? filteredJSONInputObject = JSONInputObject.SelectToken(this.FilterPathValue.Text);

                string output = (string)JsonConvert.SerializeObject(filteredJSONInputObject, Formatting.Indented);

                jsonOutputuc1.SetValue = output;

            }
        }

        private void FilterPathValue_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                JToken JSONInputObject = JToken.Parse(jsonInputuc1.GetValues);

                JToken? filteredJSONInputObject = JSONInputObject.SelectToken(this.FilterPathValue.Text);
                string output = (string)JsonConvert.SerializeObject(filteredJSONInputObject, Formatting.Indented);

                
                jsonOutputuc1.SetValue = output;


            }
            catch (Exception errorThrown) { 
                Console.WriteLine("This is my error!");
                Console.WriteLine(errorThrown);
            }
            

            
        }
    }
}
