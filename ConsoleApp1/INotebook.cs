using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1403
{
    internal interface INotebook
{
    public string Brand { get; set; }
    public string SubBrand { get; set; }
    public double Weight { get; set; }
    public byte Ram { get; set; }
    int count { get; set; }
        public void FirstAcceleration(); //Required
        public void FirstAAcceleration() { } //Optional
        public void SecondAcceleration(int t) //Optional
    {
        Console.WriteLine(t);
    }

}
}
