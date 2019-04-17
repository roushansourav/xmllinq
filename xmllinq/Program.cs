using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmllinq
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdocument = XDocument.Load("..\\..\\XMLFile2.xml");
            xdocument.Save("..\\..\\File1.xml");
            IEnumerable<XElement> employees = xdocument.Elements();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
