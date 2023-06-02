using SortingPractice.ISort;
using SortingPractice.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice.IAlgorithims
{
    public class SortingArgument : ISortingArgument
    {
        IBubbleSort bubbleSort;
      
        public SortingArgument(IBubbleSort _bubbleSort)
        {
            bubbleSort = _bubbleSort;
        }
        public void Inputs()
        {
            Console.WriteLine("please write n integers with space(' ') separator. When finished integeres press enter ");
            IList<int> randomList=  Console.ReadLine().TrimEnd().Split(' ').ToList().Select(p=> Convert.ToInt32(p)).ToList();
            Console.WriteLine("Select Algorithims: For Buble, Push 1 /n For Other, Push 2");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var sortedList= RunSelectedAlgorithms(randomList, Console.ReadLine());
            watch.Stop();
            WriterSorted(sortedList, Convert.ToDecimal(watch.ElapsedMilliseconds));
            Inputs();
        }

        public IList<int> RunSelectedAlgorithms(IList<int> randomList, string choose)
        {
            IList<int> sortedList = new List<int>();
            switch (choose)
            {
                case "1":

                    sortedList = bubbleSort.Sort(randomList);
                    return sortedList;
                case "2":
                   //sortedList = _sorting.Sort<BubbleSort>(randomList); // Diğer alg gelecek
                    return sortedList;
                default:
                    return null;
            }
        }
        public void WriterSorted(IList <int> sortedList,decimal ms )
        {
            if (sortedList == null)
            {
                Console.WriteLine("Hatalı Giriş");
                Inputs();
            }
            foreach (int i in sortedList)
            {
                Console.Write(i.ToString()+' ');
            }
            Console.WriteLine($"Execution Time: {(ms / 1000)} sec");
        }
    }
}
