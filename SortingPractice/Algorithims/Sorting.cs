using SortingPractice.ISort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice.Algorithims
{
    public class Sorting<T> : ISorting
    {
        private readonly ISorting _sorting;
        public Sorting(ISorting sorting)
        {
            _sorting = sorting;       
        }
        public IList<int> Sort(IList<int> randomList)
        {
            return _sorting.Sort(randomList);
        }
    }
}
