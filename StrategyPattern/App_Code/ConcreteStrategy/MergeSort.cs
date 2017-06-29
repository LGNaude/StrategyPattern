using System;
using System.Collections.Generic;

namespace StrategyPattern.App_Code.ConcreteStrategy
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSorted List...");
        }
    }
}
