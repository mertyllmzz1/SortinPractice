using SortingPractice.IAlgorithims;
using SortingPractice.ISort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice.Sort
{
    public class BubbleSort : IBubbleSort
    {
        #region LONG WAY
        public IList<int> Sort(IList<int> randomList)
        {
            //bool sortingDetected = false;
            //IList<int> result = new List<int>();
            //for (int i = 0; i < randomList.Count; i++)
            //{
            //    for (int j = i; j < randomList.Count; j++)
            //    {
            //        if (j < randomList.Count)
            //        {
            //            if (randomList[i] > randomList[j])
            //            {
            //                sortingDetected = true;
            //                int temp = randomList[j];
            //                randomList[j] = randomList[i];
            //                randomList[i] = temp;
            //            }
            //        }
            //    }
            //}
            //if (sortingDetected)
            //{

            //    Sort(randomList);
            //}
            //return randomList;
            #endregion
            bool sortingDetected = false;
            for (int i = 0; i < randomList.Count; i++)
            {
                if (i < randomList.Count - 1)
                {
                    if (randomList[i] > randomList[i + 1])
                    {
                        int temp = randomList[i + 1];
                        randomList[i + 1] = randomList[i];
                        randomList[i] = temp;
                        sortingDetected = true;
                    }
                }
            }
            if (sortingDetected)
            {
                Sort(randomList);
            }
            return randomList;

        }
    }
}
