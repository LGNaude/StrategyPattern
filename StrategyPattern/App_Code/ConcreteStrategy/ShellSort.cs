using System;
using System.Collections.Generic;

namespace StrategyPattern.App_Code.ConcreteStrategy
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("ShellSorted list...");
        }
    }
}
