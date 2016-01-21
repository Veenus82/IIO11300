/*
* Copyright (C) JAMK/IT/Esa Salmikangas
* This file is part of the IIO11300 course project.
* Created: 12.1.2016 Modified: 13.1.2016
* Authors: Tero ,Esa Salmikangas
*/
using System;
using System.Collections.Generic;
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

namespace JAMK.IT.IIO11300
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }


        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double RecWidth = double.Parse(txtWidth.Text);
            double RecHeight = double.Parse(txtHeight.Text);
            double RecStroke = double.Parse(txtBorder.Text);
            double PerimResult;
            double AreaResult;
            double FrameResult;
            //TODO
            try
            {
                
                PerimResult = BusinessLogicWindow.CalculatePerimeter(RecWidth, RecHeight);
                string PerimResultText = Convert.ToString(PerimResult);
                tbPerimResult.Text = PerimResultText;
                AreaResult = BusinessLogicWindow.CalculateArea(RecWidth, RecHeight);
                string AreaResultText = Convert.ToString(AreaResult);
                tbPerimResult.Text = PerimResultText;
                FrameResult = BusinessLogicWindow.CalculateFrame(RecWidth, RecHeight, RecStroke);
                string FrameResultText = Convert.ToString(FrameResult);
                tbPerimResult.Text = PerimResultText;
                tbAreaResult.Text = AreaResultText;
                tbFrameResult.Text = FrameResultText;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //yield to an user that everything okay
            }
        }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

        private void btnCalculateOO_Click(object sender, RoutedEventArgs e)
        {
            //olion avulla lasketaan pinta-ala piiiri ja hinta
            //luodaan olio
            Ikkuna ikk = new Ikkuna();
            ikk.Leveys = double.Parse(txtWidth.Text);
            ikk.Korkeus = double.Parse(txtHeight.Text);
            //VE1 pinta-alan laskeminen kutsumalla metodia
            tbAreaResult.Text = ikk.LaskePintaAla().ToString();
            //VE2 pinta-ala on olion ominaisuus
            tbAreaResult.Text = ikk.PintaAla.ToString();
        }
    }

}
