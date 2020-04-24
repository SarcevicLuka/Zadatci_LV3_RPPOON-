using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_RPPOON_LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("C:\\Users\\Korisnik\\source\\repos\\Zadatci_RPPOON_LV3\\Datoteka.txt");
            dataset.DisplayDataOnScreen();

            Dataset deepDataset = (Dataset)dataset.Clone();
            deepDataset.DisplayDataOnScreen();
        }
    }
}

/*Duboko kopiranje je potrebno ako stvaramo vise objekata klase Dataset*/