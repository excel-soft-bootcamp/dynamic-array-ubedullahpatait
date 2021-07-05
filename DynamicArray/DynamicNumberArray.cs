using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
	class DynamicNumberArray
	{
        int[] buffer;
        
        public DynamicNumberArray()
        {
            buffer = new int[5];
        }
            public DynamicNumberArray(int initialSize)
        { 

            buffer = new int[initialSize];
        }



            public void Set(int index, int value)
            {
            
            if (index>= value)

            {
                Array.Resize(ref buffer, index + 5);
            }
                buffer[index] = value;
            }


            public int Get(int index)
            {
                return buffer[index];
            }

        }
    }
