using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_RPPOON_LV3
{
    class Dataset:Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        public object Clone()
        {
            Dataset deepCopy = new Dataset();
            foreach(List<string> list in this.data)
            {
                List<string> innerList = new List<string>();
                foreach(string member in list)
                {
                    innerList.Add(member);
                }
                deepCopy.data.Add(innerList);
            }

            return deepCopy;
        }
        public void DisplayDataOnScreen()
        {
            foreach(List<string> list in GetData())
            {
                foreach(string member in list)
                {
                    Console.WriteLine(member + ' ');
                }
            }
        }
    }
}
