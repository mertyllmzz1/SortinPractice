using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice.ISort
{
    public interface ISortingArgument
    {
        public void Inputs();
        public IList<int> RunSelectedAlgorithms(IList<int> randomList,string choose);
        public void WriterSorted(IList<int> sortedList, decimal ms);
    }
}
