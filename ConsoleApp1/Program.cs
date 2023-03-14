using Classwork1403;

namespace ConsoleApp1
{
    internal class Program
    {

        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = MyProperty; }
        }


        static void Main(string[] args)
        {
            EriksNotebook eriksNotebook = new EriksNotebook();

            INotebook ieriksNotebook = new EriksNotebook();

            eriksNotebook.FirstAcceleration();
            ieriksNotebook.SecondAcceleration(98);


        }
    }
}