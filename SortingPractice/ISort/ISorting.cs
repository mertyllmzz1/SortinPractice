using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice.ISort
{
    public interface ISorting
    {
        public IList<int> Sort(IList<int> randomList);
        //public void ChooseAlg(string selection);


    }
}
