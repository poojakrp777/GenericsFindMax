using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class FindMaximum<T>
    {
        public T findMaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0)
            {
                return firstValue;
            }
            else if (Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
    }
}
