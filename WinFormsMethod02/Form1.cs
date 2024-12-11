using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsMethod02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            /*double r = 0;
            if (!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("Wrong Data!!!", "Error.");
                return;
            }
            CircleArea(r); */
            //CircleArea(txtRadius);
            CircleArea(txtRadius, lblResult);
            Finish();
        }
        void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            lblResult.Text = area.ToString("#.##");
        }

        void CircleArea(TextBox txt)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("มีข้อผิดพลาด", "Error.");
                return;
            }
            double area = Math.PI * r * r;
            lblResult.Text = area.ToString("#.##");
        }
        void CircleArea(TextBox txt, Label lbl)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("มีข้อผิดพลาด", "Error.");
                return;
            }
            double area = Math.PI * r * r;
            lbl.Text = area.ToString("#.##");
        }

        private void btnCicumference_Click(object sender, EventArgs e)
        {
            double r = 0;
            if (!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("มีข้อผิดพลาด", "Error.");
                return;
            }
            lblResult.Text = Circumference(r).ToString("#.##");
            Finish();
        }

        double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        string triangle(string letter = "*", int size = 5)
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }
            return result;
        }

        private void Finish()
        {
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangle01_Click(object sender, EventArgs e)
        {
            //txtOutput.Text = triangle();
            //txtOutput.Text = triangle(txtLetter.Text);
            txtOutput.Text = triangle(txtLetter.Text, 9);
        }

        void ImproveName(ref string name)
        {
            string sName = name;
            name = name.Trim();
            if (name.Length < 2)
            {
                MessageBox.Show("กรุณากรอกชื่อ", "Error");
                name = sName;
                return;
            }
        }
        string ImproveName2(string name)
        {
            string sName = name;
            name = name.Trim();
            if (name.Length < 2)
            {
                MessageBox.Show("กรุณากรอกชื่อ", "Error");
                name = sName;
            }
            return name;
        }

        private void btnRefParameter_Click(object sender, EventArgs e)
        {
            string FName = txtInput.Text;
            //ImproveName(ref FName);
            //txtInput.Text = FName;
            txtInput.Text = ImproveName2(FName);
        }
        bool improveName3(string name, out string x)
        {
            x = name.Trim();
            if (x.Length < 2)
            {
                x = "";
                return false;
            }
            return true;
        }

        private void btnOutputParameter_Click(object sender, EventArgs e)
        {
            string Fname = "";
            if (improveName3(txtInput.Text, out Fname))
            {
                txtInput.Text = Fname;
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูล", "Error.");
            }
        }

        private void btnArrayParamiter_Click(object sender, EventArgs e)
        {
            double[] data = new double[] { 1.5, 2.0, 3.25, 0.15 };
            double summary = sum(data);
            string result = string.Join("/", data);
            result += Environment.NewLine;
            result += summary.ToString();
            MessageBox.Show(result, "The sum in array.");
        }

        double sum(double[] dataArray)
        {
            double sum = 0;
            foreach (double d in dataArray)
            {
                sum += d;
            }
            return sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
