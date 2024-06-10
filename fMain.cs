using System;
using System.Windows.Forms;

namespace _2lab_6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        public abstract class Shape
        {
            public abstract double GetArea();
        }

        public class Parallelogram : Shape
        {
            public double Basis { get; set; }
            public double Height { get; set; }

            public Parallelogram(double basis, double height)
            {
                Basis = basis;
                Height = height;
            }

            public override double GetArea()
            {
                return Basis * Height;
            }
        }

        public class Trapezium : Shape
        {
            public double UpBasis { get; set; }
            public double DownBasis { get; set; }
            public double Height { get; set; }

            public Trapezium(double upBasis, double downBasis, double height)
            {
                UpBasis = upBasis;
                DownBasis = downBasis;
                Height = height;
            }

            public override double GetArea()
            {
                return 0.5 * (UpBasis + DownBasis) * Height;
            }
        }
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double basis = double.Parse(tbBasis.Text);
                double parHeight = double.Parse(tbHeight.Text);
                Shape parallelogram = new Parallelogram(basis, parHeight);
                SPar.Text = parallelogram.GetArea().ToString();

                double upBasis = double.Parse(tbUpBasis.Text);
                double downBasis = double.Parse(tbDownBasis.Text);
                double trapHeight = double.Parse(tbTrapHeight.Text);
                Shape trapezium = new Trapezium(upBasis, downBasis, trapHeight);
                STrap.Text = trapezium.GetArea().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.");
            }
        }
    }
}
