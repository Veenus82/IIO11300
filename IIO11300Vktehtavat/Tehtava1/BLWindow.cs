using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.IIO11300
{
    public class Ikkuna
    {
        #region Muuttujat (variables)
        private double korkeus;
        private double leveys;
        //private double pintaala
        #endregion
        #region Ominaisuudet (properties)
        //olio suunnittelun aikana on päätetty että pinta-ala ja hinta oavat read-only ominaisuuksia
        public double PintaAla
        {
            get
            {
                return korkeus * leveys;
            }
        }
        public float Hinta
        {
            get
            {
                return LaskeHinta();
            }
        }
        public double Korkeus
        {
            get
            {
                return korkeus;
            }
            set
            {
                //tässä kohdassa voisi tarvittaessa tehdä tarkistuksen
                korkeus = value;
            }
        }
     
        public double Leveys
        {
            get { return leveys; }
            set { leveys = value; }
        }

        #endregion
        #region Konstruktorit (constructors)

        #endregion
        #region Metodit (methods)
        public double LaskePintaAla()
        {
            return korkeus * leveys;
        }
        private float LaskeHinta()
        {
            //hinta lasketaan työn, materiaalimenekin ja katteen avulla
            float kate = 100;
            float tyo = 200;
            float materiaali;
            materiaali = 100 * (float)(leveys * korkeus / 100000);
            return (kate + tyo + materiaali);
        }
        #endregion

    }
    public class IkkunaVE0
    {
        //joskus tehdään näin "oikaistaan"
        //Esa ei suosittele
        public double korkeus;
        public double leveys;
        public double LaskePintaAla()
        {
            return korkeus * leveys;
        }
        
    }
    public class BusinessLogicWindow
    {
        /// <summary>
        /// CalculatePerimeter calculates the perimeter of a window
        /// </summary>
        public static double CalculatePerimeter(double width, double height)
        {
           return width * 2 + height * 2;
           throw new System.NotImplementedException();
        }

        public static double CalculateArea(double width, double height)
        {
            return width * height;
            throw new System.NotImplementedException();
        }

        public static double CalculateFrame(double width, double height, double stroke)
        {
            return ((width * height) - ((stroke - width) * (stroke - height)));
            throw new System.NotImplementedException();
        }
    }
}
