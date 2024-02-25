using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_13.Arsenii.Ziubin
{
    internal class Collector
    {
        public string NamePostCar { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Quantity { get; set; }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Collector() { }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="S">Data of student object to be copied from</param>
        public Collector(Collector S)
        {
            this.NamePostCar = S.NamePostCar;
            this.Country = S.Country;
            this.Year = S.Year;
            this.Type = S.Type;
            this.Height = S.Height;
            this.Width = S.Width;
            this.Quantity = S.Quantity;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="NameSurname"> Student name and surname (string)</param>
        /// <param name="L1">Evaluation of L1 (int)</param>
        /// <param name="L2">Evaluation of L2 (int)</param>
        /// <param name="L3">Evaluation of L3 (int)</param>
        /// <param name="L4">Evaluation of L4 (int)</param>
        public Collector( string NamePostCar, string Country, int Year, string Type, 
            int Height, int Width, int Quantity)
        {
            this.NamePostCar = NamePostCar;
            this.Country = Country;
            this.Year = Year;
            this.Type = Type;
            this.Height = Height;
            this.Width = Width;
            this.Quantity = Quantity;
        }
        // Overridden method Equals(), check object equality
        public override bool Equals(object myObject)
        {
            Collector stud = myObject as Collector;
            return stud.NamePostCar == NamePostCar;
        }

        /// <summary>
        /// Student comparison method (comparer)
        /// </summary>
        /// <param name="other">Another student to be compared with</param>
        /// <returns> 1 if L1 evaluation is greater than evaluation of other L1
        /// -1 if L1 evaluation is less than evaluation of other L1
        /// 0 otherwise
        /// </returns>
        public int CompareTo(Collector other)
        {
            if (this.Year > other.Year)
                return 1;
            else if (this.Year < other.Year)
                return -1;
            if(this.NamePostCar.CompareTo(other.NamePostCar) < 0)
            {
                return 1;
            }
            else if(this.NamePostCar.CompareTo(other.NamePostCar) > 0)
            {
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Method for creating a string output from class properties (data fields)
        /// </summary>
        /// <returns>NameSurname, L1, L2, L3, L4 properties with average value of all lab works
        /// concatenated to single string</returns>
        public override string ToString()
        {
            return string.Format("{0,-2:d} {1,-12:d} {2,-7:d} {3,-7:d} {4,-7:d} {5,-8:f2} {6,5:d} ",
            NamePostCar, Country, Year, Type, Height, Width, Quantity);
        }

    }
}
