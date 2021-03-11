using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualizer
{
    interface ISortEngine
    {
       void DoWork(int[] ArrayToSort, Graphics g, int MaxValue);
            
    }
}
