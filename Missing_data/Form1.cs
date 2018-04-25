using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Working with files
using System.Threading; // For multiple threads

namespace Missing_data
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofdInputComplete;
        OpenFileDialog ofdInputMissing;
        OpenFileDialog ofdOutput;

        string[] columnNames;
        List<double[]> inputList = new List<double[]>();
        List<double[]> outputList = new List<double[]>();

        public AutoResetEvent waitHandle = new AutoResetEvent(false);

        public Form1()
        {
            InitializeComponent();

            ofdInputComplete = new OpenFileDialog();
            ofdInputMissing = new OpenFileDialog();
            ofdOutput = new OpenFileDialog();
        }

        private void btnInputLoc_Click(object sender, EventArgs e)
        {
            if (ofdInputComplete.ShowDialog() == DialogResult.OK)
            {
                tbInputCompleteLoc.Text = ofdInputComplete.FileName.Replace('\\', '/');
            }
        }

        private void btnOutputLoc_Click(object sender, EventArgs e)
        {
            if (ofdOutput.ShowDialog() == DialogResult.OK)
            {
                tbOutputLoc.Text = ofdOutput.FileName.Replace('\\', '/');
            }
        }

        private void updateDgvInput()
        {
            inputList.Clear();

            if (File.Exists(tbInputMissingLoc.Text))
            {
                List<string[]> source = File.ReadLines(tbInputMissingLoc.Text).Select(line => line.Split('\t')).ToList(); // Reading the file

                // Detach column names from data
                columnNames = source[0];
                source.RemoveAt(0);

                // Update inputList
                for (int i = 0; i < source.Count; i++)
                {
                    double[] d = new double[source[i].Length];
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        if (source[i][j] == "")
                            d[j] = double.NaN;
                        else
                            d[j] = Convert.ToDouble(source[i][j]);
                    }
                    inputList.Add(d);
                }

                dgvInput.Columns.Clear();

                // Set up column names
                for (int i = 0; i < columnNames.Length; i++)
                {
                    DataGridViewCell dgvCell = new DataGridViewTextBoxCell();
                    DataGridViewColumn dgvCol = new DataGridViewColumn(dgvCell);
                    dgvCol.HeaderText = columnNames[i];
                    dgvCol.Visible = true;
                    dgvCol.Width = 40;
                    dgvCol.SortMode = DataGridViewColumnSortMode.Automatic;
                    dgvInput.Columns.Add(dgvCol);
                }

                // Fill up dgvInput
                dgvInput.Rows.Clear();
                for (int i = 0; i < inputList.Count; i++)
                {
                    for (int j = 0; j < inputList[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            dgvInput.Rows.Add(inputList[i][j]);
                        }
                        else
                        {
                            dgvInput.Rows[i].Cells[j].Value = inputList[i][j];
                        }

                    }
                }
                dgvInput.Refresh();
            }
            else
            { 
                MessageBox.Show("Missing data file does not exist!", "Incorrect file location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void updateDgvOutput()
        {
            outputList.Clear();

            if(File.Exists(tbOutputLoc.Text))
            {
                List<string[]> source = File.ReadLines(tbOutputLoc.Text).Select(line => line.Split('\t')).ToList(); // Reading the file

                // Detach column names from data
                columnNames = source[0];
                source.RemoveAt(0);

                // Update outputList
                for (int i = 0; i < source.Count; i++)
                {
                    double[] d = new double[source[i].Length];
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        if (source[i][j] == "")
                            d[j] = double.NaN;
                        else
                            d[j] = Convert.ToDouble(source[i][j]);
                    }
                    outputList.Add(d);
                }

                dgvOutput.Columns.Clear();
                // Set up column names
                for (int i = 0; i < columnNames.Length; i++)
                {
                    DataGridViewCell dgvCell = new DataGridViewTextBoxCell();
                    DataGridViewColumn dgvCol = new DataGridViewColumn(dgvCell);
                    dgvCol.HeaderText = columnNames[i];
                    dgvCol.Visible = true;
                    dgvCol.Width = 40;
                    dgvCol.SortMode = DataGridViewColumnSortMode.Automatic;
                    dgvOutput.Columns.Add(dgvCol);
                }

                // Fill up dgvOutput
                dgvOutput.Rows.Clear();
                for (int i = 0; i < outputList.Count; i++)
                {
                    for (int j = 0; j < outputList[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            dgvOutput.Rows.Add(outputList[i][j]);
                        }
                        else
                        {
                            dgvOutput.Rows[i].Cells[j].Value = outputList[i][j];
                        }

                    }
                }
                dgvOutput.Refresh();
            }
            else
            { 
                MessageBox.Show("Output data file does not exist!", "Incorrect file location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInputMissingLoc_Click(object sender, EventArgs e)
        {
            if (ofdInputMissing.ShowDialog() == DialogResult.OK)
            {
                tbInputMissingLoc.Text = ofdInputMissing.FileName.Replace('\\', '/');
            }
        }

        private void btnCreateMissingFile_Click(object sender, EventArgs e)
        {
            try
            {
                List<string[]> source = File.ReadLines(tbInputCompleteLoc.Text).Select(line => line.Split('\t')).ToList(); // Reading the file

                string[] colNames = source[0]; // Set up column names
                colNames = colNames.Take(colNames.Length - 1).ToArray(); //Remove last column because data is bugged
                source.RemoveAt(0);

                // Creating missing data file
                int missingness = 10; // 10% will be missing

                Random rnd = new Random();

                for (int i = 0; i < source.Count; i++)
                {
                    for (int j = 1; j < source[i].Length; j++) // We presume that time is a complete variable
                    {
                        int random = rnd.Next(100);
                        if (random < missingness)
                        {
                            source[i][j] = "";
                        }
                    }
                }

                source.Insert(0, colNames); // Put column names back
                // Write data into file
                List<string> s = new List<string>();
                for (int i = 0; i < source.Count; i++)
                {
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            s.Add(source[i][j]);
                        }
                        else
                        {
                            s[i] += "\t" + source[i][j];
                        }
                    }
                }
                File.WriteAllLines(tbInputMissingLoc.Text, s);

                // Update table
                updateDgvInput();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Specify complete and missing data file locations", "Incorrect file locations", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            updateDgvInput();

            RadioButton radioBtn = this.gbMethod.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault(); // Check which radio button is checked

            new Thread(() =>
            {
                if (radioBtn != null)
                {
                    switch (radioBtn.Name)
                    {
                        case "rbListwise":
                            ListwiseDeletion();
                            break;
                        case "rbPairwise":
                            PairwiseDeletion();
                            break;
                        case "rbMean":
                            MeanSubstitution();
                            break;
                        case "rbColdDeck":
                            ColdDeckImputation();
                            break;
                        case "rbHotDeck":
                            HotDeckImputation();
                            break;
                        case "rbLinearRegression":
                            LinearRegression();
                            break;
                    }
                }
                Thread.Sleep(1000);
                waitHandle.Set();
            })
            { IsBackground = true }.Start();

            waitHandle.WaitOne();

            // Convert output to string
            List<string[]> str = new List<string[]>();
            for (int i = 0; i < outputList.Count; i++)
            {
                string[] d = new string[outputList[i].Length];
                for (int j = 0; j < outputList[i].Length; j++)
                {
                    d[j] = Convert.ToString(outputList[i][j]);
                }
                str.Add(d);
            }

            str.Insert(0, columnNames); // Put column names back

            // Write data into file
            List<string> s = new List<string>();
            for (int i = 0; i < str.Count; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (j == 0)
                    {
                        s.Add(str[i][j]);
                    }
                    else
                    {
                        s[i] += "\t" + str[i][j];
                    }
                }
            }
            File.WriteAllLines(tbOutputLoc.Text, s);

            updateDgvOutput();
        }

        public void ListwiseDeletion()
        {
            outputList = inputList;

            for (int i = 0; i < outputList.Count; i++)
            {
                for (int j = 0; j < outputList[i].Length; j++)
                {
                    if (double.IsNaN(outputList[i][j]))
                    {
                        outputList.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }

        public void PairwiseDeletion()
        {

        }

        public void MeanSubstitution()
        {
            outputList = inputList;

            double[] mean = new double[outputList[0].Length];
            double[] n = new double[outputList[0].Length];

            // Calculate mean values
            for (int i = 0; i < outputList.Count; i++)
            {
                for (int j = 1; j < outputList[i].Length; j++)
                {
                    if (double.IsNaN(outputList[i][j]))
                    {
                        continue;
                    }
                    else
                    {
                        mean[j] += outputList[i][j];
                        n[j]++;
                    }
                }
            }

            for (int i = 1; i < mean.Length; i++)
            {
                mean[i] /= n[i];
                mean[i] = Math.Round(mean[i], 2);
            }

            // Impute mean values istead of NaN
            for (int i = 0; i < outputList.Count; i++)
            {
                for (int j = 1; j < outputList[i].Length; j++)
                {
                    if (double.IsNaN(outputList[i][j]))
                    {
                        outputList[i][j] = mean[j];
                    }
                }
            }
        }

        public void ColdDeckImputation()
        {
            outputList = inputList;

            for (int i = 0; i < outputList.Count; i++)
            {
                for (int j = 1; j < outputList[i].Length; j++)
                {
                    if (double.IsNaN(outputList[i][j]))
                    {
                        outputList[i][j] = 0;
                    }
                }
            }
        }

        public void HotDeckImputation()
        {
            outputList = inputList;

            for (int i = 0; i < outputList.Count; i++)
            {
                double[] squareSum = new double[outputList.Count];

                // Calculate squareSum for each row in relation to this row
                for (int k = 0; k < outputList.Count; k++)
                {
                    for (int l = 1; l < outputList[i].Length; l++)
                    {
                        if (double.IsNaN(outputList[k][l]))
                        {
                            squareSum[k] = double.MaxValue;
                            break;
                        }
                        else if (double.IsNaN(outputList[i][l]))
                        {
                            continue;
                        }
                        else
                        {
                            squareSum[k] += (outputList[k][l] - outputList[i][l]) * (outputList[k][l] - outputList[i][l]);
                        }
                    }
                }

                // Use the one with least square sum
                int leastSquareSumIndex = Array.IndexOf(squareSum, squareSum.Min());

                for (int j = 1; j < outputList[i].Length; j++)
                {
                    if (double.IsNaN(outputList[i][j]))
                    {
                        outputList[i][j] = outputList[leastSquareSumIndex][j];
                    }
                }
            }
        }

        public void LinearRegression()
        {
            outputList = inputList;

            // Calculate necessary parameters for each electrode 
            double[] a = new double[outputList[0].Length];
            double[] b = new double[outputList[0].Length];
            double sumX = 0;
            double[] sumY = new double[outputList[0].Length];
            double[] sumXY = new double[outputList[0].Length];
            double sumX2 = 0;
            double[] n = new double[outputList[0].Length];

            for (int i = 0; i < outputList.Count; i++)
            {
                sumX += outputList[i][0];
                sumX2 += outputList[i][0] * outputList[i][0];

                for (int j = 1; j < outputList[i].Length; j++)
                {
                    if (double.IsNaN(outputList[i][j]))
                    {
                        continue; 
                    }
                    else
                    {
                        sumY[j] += outputList[i][j];
                        sumXY[j] += outputList[i][0] * outputList[i][j];
                        n[j]++;
                    }
                }
            }

            // Calculate coefficients a and b
            for (int j = 1; j < outputList[0].Length; j++)
            {
                b[j] = (n[j] * sumXY[j] - sumX * sumY[j]) / (n[j] * sumX2 - sumX * sumX);
                a[j] = (sumY[j] - b[j] * sumX) / n[j];
            }

            // Use y = a + bx to substitute missing values
            for (int i = 0; i < outputList.Count; i++)
            {
                for (int j = 1; j < outputList[i].Length; j++)
                {
                    if (double.IsNaN(outputList[i][j]))
                    {
                        outputList[i][j] = Math.Round(a[j] + b[j] * outputList[i][0], 2);
                    }
                }
            }
        }
    }
}
