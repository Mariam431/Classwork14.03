using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1403
{
    internal class EriksNotebook : INotebook
    {
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public int count { get; set; }

        public void FirstAcceleration()
        {
            Console.WriteLine("Brand" + Brand);
            Console.WriteLine("EriksNoteBook : INotebook++FirstAccelaration");
        }

        void INotebook.SecondAcceleration(int u)
        {
            Console.WriteLine(u);
        }

    }
}
