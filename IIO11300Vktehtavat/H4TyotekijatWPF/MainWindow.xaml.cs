using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;


namespace H4TyotekijatWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        XElement xe;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnReadXML_Click(object sender, RoutedEventArgs e)
        {
            // luetaan XML-tiedostosta työntekijä-elementit ja sidotaan ne DataGridiin
            try
            {
                string filu = "d:\\työntekijät2013.xml"; // tiedostonimi kovakoodattu, välttäkää kovakoodausta!!
                XElement xe = XElement.Load(filu);
                dgData.DataContext = xe.Elements("tyontekija");
                tbMessage.Text = string.Format("Työntekijöitä {0} ja palkat yhteensä {1}", CountWorkers("vakituinen"), CalculateSalarySum("vakituinen"));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private int CountWorkers(string tyosuhde)
        {
            int lkm = 0;
            // lasketaan LINQ-kyselyllä tietyntyyppiset työntekijät
            var temp = from ele in xe.Elements()
                       where ele.Element("tyosuhde").Value == tyosuhde
                       select ele.Elements("sukunimi");
            lkm = temp.Count();
            return lkm;
        }
        private decimal CalculateSalarySum(string tyosuhde)
        {
            decimal sum = 0;
            var palkat = from ele
                         in xe.Elements()
                         where ele.Element("tyosuhde").Value == tyosuhde
                         select ele.Element("palkka").Value;
            foreach (var item in palkat)
            {
                System.Diagnostics.Debug.Print(item.ToString());
                    sum += decimal.Parse(Item);
            }
          
            return sum;
        }
    }
}
