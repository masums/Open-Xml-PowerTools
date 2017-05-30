using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Guid.NewGuid().ToString() + "_" + "tableExample.docx";
            DocTableCreator.CreateDocument(fileName);
            DocTableCreator.AddTable(fileName);
        }
    }
}
