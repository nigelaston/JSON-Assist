using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq.Expressions;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

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
                try
                {
                    JToken JSONInputObject = JToken.Parse(jsonInputuc1.GetValues);

                    JToken? filteredJSONInputObject = JSONInputObject.SelectToken(this.FilterPathValue.Text);

                    string output = (string)JsonConvert.SerializeObject(filteredJSONInputObject, Formatting.Indented);

                    jsonOutputuc1.SetValue = output;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
            catch (Exception errorThrown)
            {
                Console.WriteLine("This is my error!");
                Console.WriteLine(errorThrown);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {


            //Open a stream
            Stream saveJSONStream;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = @"C:\Users\nigel.aston\Documents\Coding\Visual Studio\Source\Repos\My Tools\My Tools\JSONFiles";
            saveFileDialog.DefaultExt = ".json";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveJSONStream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.

                    string fullPath = saveFileDialog.FileName;  // Full path with filename
                    string fileName = Path.GetFileName(fullPath);  // Extract only the filename
                    string directoryPath = Path.GetDirectoryName(fullPath);  // Extract only the folder path

                    saveJSONStream.Close();

                    MessageBox.Show($"Fullpath: {fullPath} \n fileName: {fileName} \n directoryPath {directoryPath}");

                    // Write the JSON string to a file
                    JToken JSONInputObject = JToken.Parse(jsonInputuc1.GetValues);
                    JToken? filteredJSONInputObject = JSONInputObject.SelectToken(this.FilterPathValue.Text);
                    string output = (string)JsonConvert.SerializeObject(filteredJSONInputObject, Formatting.Indented);
                    File.WriteAllText(fullPath, output);
                }
            }


        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

            //Opens a chosen file;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of the file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();

                        jsonOutputuc1.SetValue = fileContent;
                        jsonInputuc1.SetValue = fileContent;
                    }
                }
            }

        }
    }
}
