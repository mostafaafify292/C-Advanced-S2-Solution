using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_S2
{
    internal class FixedSizeList<T>
    {
        private List<T> list;
        private int capacityOfList;
       




        public FixedSizeList(int capacityOfList)
        {
            this.capacityOfList = capacityOfList;
            list = new List<T>(capacityOfList);
        }


        public void Add(T item) 
        {
            if (list.Capacity <= capacityOfList)
            {
                list.Add(item);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }


        public List<T> LIST
        {
            get
            {
                foreach (T item in list)
                {
                    Console.WriteLine(item);
                }
                return list;

            }
        }
        public int CapacityOfList
        {
            get 
            { 
             return capacityOfList;
            }
        
        }




        public T this[int index]
        {
            get 
            {
                if (index > capacityOfList)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return list[index]; 
            }
            set 
            {
                if (index > capacityOfList)
                {
                    throw new ArgumentOutOfRangeException();
                }
                list[index] = value;

            }
        }
        public override string ToString()
        {
            return $" LIST = {LIST} " ;
        }

    }
}
