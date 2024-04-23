using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace GDK_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OperationSelection.SelectedIndex = 0;
        }

        Complex a, b, c = new Complex(0.0, 0.0);
        String rA, iA, rB, iB = "0,0";

        string save_file_name = "calculation_history.txt";

        private void InputTextChanged(object sender, EventArgs e)
        {
            rA = realA.Text.Replace('.', ',');
            iA = imagA.Text.Replace('.', ',');
            rB = realB.Text.Replace('.', ',');
            iB = imagB.Text.Replace('.', ',');
            //
            if (rA.Length < 1 || rA == ",") rA = "0,0";
            if (iA.Length < 1 || iA == ",") iA = "0,0";
            if (rB.Length < 1 || rB == ",") rB = "0,0";
            if (iB.Length < 1 || iB == ",") iB = "0,0";
            //
            if (rA.StartsWith(",")) rA.Replace(",", "0,");
            if (iA.StartsWith(",")) iA.Replace(",", "0,");
            if (rB.StartsWith(",")) rB.Replace(",", "0,");
            if (iB.StartsWith(",")) iB.Replace(",", "0,");
            //
            if (rA.EndsWith(",")) rA.Replace(",", ",0");
            if (iA.EndsWith(",")) iA.Replace(",", ",0");
            if (rB.EndsWith(",")) rB.Replace(",", ",0");
            if (iB.EndsWith(",")) iB.Replace(",", ",0");
            //
            a = new Complex(Double.Parse(rA), Double.Parse(iA));
            b = new Complex(Double.Parse(rB), Double.Parse(iB));
            switch (OperationSelection.SelectedItem)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "^":
                    c = Complex.Pow(a, b);
                    break;
                case "√":
                    c = Complex.Sqrt(a);
                    break;
                case "rad":
                    c = new Complex(Complex.Abs(a), 0.0);
                    break;
                case "sin":
                    c = Complex.Sin(a);
                    break;
                case "cos":
                    c = Complex.Cos(a);
                    break;
                case "tg":
                    c = Complex.Tan(a);
                    break;
                case "ctg":
                    c = 1 / Complex.Tan(a);
                    break;
                case "sinh":
                    c = Complex.Sinh(a);
                    break;
                case "cosh":
                    c = Complex.Cosh(a);
                    break;
                case "tgh":
                    c = Complex.Tanh(a);
                    break;
                case "ctgh":
                    c = 1 / Complex.Tanh(a);
                    break;
                default:
                    OperationSelection.SelectedIndex = 0;
                    c = a + b;
                    break;
            }
            realC.Text = c.Real.ToString();
            imagC.Text = c.Imaginary.ToString();
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox text_box)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || (e.KeyChar == '.' || e.KeyChar == ',') && (!text_box.Text.Contains('.') && !text_box.Text.Contains(',')) && (true || text_box.Text.Length > 0)))
                {
                    e.Handled = true;
                }
            }
        }

        private void OperationSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OperationSelection.SelectedItem)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "^":
                    realB.ReadOnly = false;
                    imagB.ReadOnly = false;
                    break;
                case "√":
                case "rad":
                case "sin":
                case "cos":
                case "tg":
                case "ctg":
                case "sinh":
                case "cosh":
                case "tgh":
                case "ctgh":
                    realB.ReadOnly = true;
                    imagB.ReadOnly = true;
                    break;
                default:
                    realB.ReadOnly = false;
                    imagB.ReadOnly = false;
                    break;
            }
            InputTextChanged(sender, e);
        }

        private void ResultToInput_Click(object sender, EventArgs e)
        {
            if (!double.IsNaN(c.Real) && !double.IsNaN(c.Imaginary))
            {
                a = c;
                realA.Text = c.Real.ToString();
                imagA.Text = c.Imaginary.ToString();
            }
        }

        private string str(Complex num)
        {
            return ("(" + num.Real.ToString() + ", " + num.Imaginary.ToString() + ")");
        }

        private string GetCurrentOperation()
        {
            switch (OperationSelection.SelectedItem)
            {
                case "+":
                    return str(a) + " + " + str(b) + " = " + str(c);
                case "-":
                    return str(a) + " - " + str(b) + " = " + str(c);
                case "*":
                    return str(a) + " * " + str(b) + " = " + str(c);
                case "/":
                    return str(a) + " / " + str(b) + " = " + str(c);
                case "^":
                    return str(a) + " ^ " + str(b) + " = " + str(c);
                case "√":
                    return "√" + str(a) + " = " + str(c);
                case "rad":
                    return "rad" + str(a) + " = " + c.Real;
                case "sin":
                    return "sin" + str(a) + " = " + str(c);
                case "cos":
                    return "cos" + str(a) + " = " + str(c);
                case "tg":
                    return "tg" + str(a) + " = " + str(c);
                case "ctg":
                    return "ctg" + str(a) + " = " + str(c);
                case "sinh":
                    return "sinh" + str(a) + " = " + str(c);
                case "cosh":
                    return "cosh" + str(a) + " = " + str(c);
                case "tgh":
                    return "tgh" + str(a) + " = " + str(c);
                case "ctgh":
                    return "ctgh" + str(a) + " = " + str(c);
                default:
                    return str(a) + " + " + str(b) + " = " + str(c);
            }
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                { Arguments = folderPath, FileName = "explorer.exe" };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        private void OpenSaveDirectory_Click(object sender, EventArgs e)
        {
            var str = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            OpenFolder(str.Substring(6, str.Length - 6));
        }

        private void SaveToHistory_Click(object sender, EventArgs e)
        {
            CalculationHistory.Text = GetCurrentOperation() + "\n" + CalculationHistory.Text;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            realA.Text = "";
            imagA.Text = "";
            realB.Text = "";
            imagB.Text = "";
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            CalculationHistory.Text = "";
        }

        private void SaveHistory()
        {
            if (SaveHistoryToFile.Checked)
            {
                File.WriteAllText(save_file_name, CalculationHistory.Text);
            }
        }

        private void CalculationHistory_TextChanged(object sender, EventArgs e)
        {
            SaveHistory();
        }
    }
}
