using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmsVisualizer
{
    class BubbleSortEngine : ISortEngine
    {

        private bool Sorted = false;
        private int[] TheArray;
        int MaxVal;
        private Graphics g;

        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);


        public void DoWork(int[] ArrayToSort, Graphics g, int MaxValue)
        {
            TheArray = ArrayToSort;
            MaxVal = MaxValue;
            this.g = g;

            while ( !Sorted )
            {
                for ( int i = 0; i < TheArray.Count() - 1; i++ )
                {
                    if ( TheArray[i] > TheArray[i + 1] )
                    {
                        Swap(i, i + 1);
                    }


                }

                Sorted = isSorted();
            }

        }

        private void Swap(int i, int p)
        {
            int temp = TheArray[i];
            TheArray[i] = TheArray[i + 1];
            TheArray[i + 1] = temp;


            g.FillRectangle(BlackBrush, i, 0, 1, MaxVal);
            g.FillRectangle(BlackBrush, p, 0, 1, MaxVal);

            g.FillRectangle(WhiteBrush, i, MaxVal - TheArray[i], 1, MaxVal);
            g.FillRectangle(WhiteBrush, p, MaxVal - TheArray[p], 1, MaxVal);

        }

        private bool isSorted()
        {
            for ( int i = 0; i < TheArray.Count() - 1; i++ )
            {
                if(TheArray[i] > TheArray[i+1]) return false;
            }
            return true;
        }
    }
}
