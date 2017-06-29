using System;
using System.Collections.Generic;

namespace StrategyPattern.App_Code
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
