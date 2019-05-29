using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIE_1931_Lightness
{

    public partial class CIE_1931 : Form
    {

        public static class Globals
        {
            public static String pathToSave = String.Empty; // Modifiable
            public static String globalPath = String.Empty;
        }

        public CIE_1931()
        {
            InitializeComponent();
            SelectButton.Click += SelectButton_Click;
            Generate.Click += Generate_Click;
        }

        private void CIE_1931_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSelected = new FolderBrowserDialog();

            if (folderSelected.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderSelected.SelectedPath);
            }

            Globals.globalPath = folderSelected.SelectedPath.ToString() + "\\";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Res_From_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int input = int.Parse(InputSize.Text);
            int output = int.Parse(OutputSize.Text);
            int start = int.Parse(StartFrom.Text);

            List<int> luminance = GenerateFormula(input, output, start);


            if (Globals.globalPath.Length <= 2)
            {
                Globals.globalPath = "cie1931.h";
            }
            else if (!(Globals.globalPath[Globals.globalPath.Length - 1].ToString() == "h"))
            {
                Globals.globalPath += "cie9131.h";
            }

            MakeUnique(Globals.globalPath);

            SaveToFile(luminance, Globals.pathToSave, 255);
        }

        private List<int> GenerateFormula(int inSize, int outSize, int start)
        {
            List<int> luminance = new List<int>(); 

            for (double i = start; i <= inSize; i++)
            {
                double lightness = i / inSize;
                double percentage = Cie1931(lightness);
                percentage *= outSize;
                percentage = Math.Round(percentage);

                luminance.Add((int)percentage);
            }

            return luminance;
        }

        private double Cie1931(double lightness)
        {
            double output = 0;
            lightness *= 100;
            if (lightness <= 8)
            {
                output = lightness / 902.3;
                return (output);
            }
            else
            {
                output = (lightness + 16) / 116;
                output = Math.Pow(output, 3);
                return (output);
            }
        }

        public FileInfo MakeUnique(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);

            for (int i = 1; ; ++i)
            {
                if (!File.Exists(path))
                {
                    Globals.pathToSave = path;
                    return new FileInfo(path);
                }

                path = Path.Combine(dir, fileName + "(" + i + ")" + fileExt);
            }
        }

        private void SaveToFile(List<int> input, string path, int outSize)
        {

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("// CIE 1931 correction table");
                    sw.WriteLine("// Automatically generated");
                    sw.WriteLine("// By Toni Stoyanov");
                    sw.WriteLine("");
                    sw.Write($"const uint16_t cie[{input.Count}] = ");
                    sw.WriteLine("{");

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (i > 0)
                        {
                            sw.Write(",");
                        }

                        if (i % 10 == 9)
                        {
                            sw.WriteLine();
                        }

                        string toText = input[i].ToString();

                        sw.Write($" {toText}");

                    }

                    sw.Write("};");

                    sw.Close();

                    MessageBox.Show($"File saved to: {path}" , "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Res_To_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
