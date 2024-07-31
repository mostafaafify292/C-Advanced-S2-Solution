using System.Collections;
using System.Collections.Generic;
namespace C__Advanced_S2
{
    internal class Program
    {

        public static int SumArrayList(ArrayList arrayList)
        {
            int Sum = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                Sum += (int)arrayList[i];   

            }
            return Sum;
        }
        public static void ReverseArrayList(ArrayList arrayList) 
        {
            int[] arr = new int[arrayList.Count];
            int helper = 0;
            for (int a = arrayList.Count - 1; a <= arrayList.Count - 1 && a >= 0; a--)
            {
                arr[helper] = (int)arrayList[a];
                helper++;
            }
            arrayList.Clear();
            arrayList.TrimToSize();
            arrayList.AddRange(arr);
        }

        public static List<int> evenNumbersOnList(List<int> list)
        {
            List<int> testList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    testList.Add(list[i]);
                }
            }
            return testList ; 

        }
        static void Main(string[] args)
        {
            ///   Non generic collections:[arrayList , SortedArray , Stack , Queue , Hashtable]
            /// all of generic collection depend on [array]
            ///            [arrayList] dynamic length ,arrayOfObject

            #region PART 01 	Write a Report about all Collections Given in the Session and Compare [Structure, Time Complexity, and Business Case With Implemented Examples]

            ////[ArrayList] is list of array , Heterogeneous , Non-Generic , make more of Boxing and UnBoxing , O(1) on Retrieve
            ////            can not enforce type safety

            //// [List]   is list of array , Homogeneous , Generic , can enforce type safety , Dynamic Length , O(1) on Retrieve

            //  [LinkedList]  is a list of nodes , homogeneous , Generic , Dynamic Length , O(1) on ADDING , O(n) on Retrieve

            //  [Stack]   is array of T[] , firest In last out ,last in firest out ,like Box , Generic and Non , Dynami Length

            //  [Queue]   is array of T[] , first in first out ,last in last out , like [Row] , Generic , Dynamic Length

            //  [Dictionary]  is pair of Key , Value , Generic-HashTable , enforce type safety , retrieve O(1) 




            #endregion

            #region Non-Generic ArrayList
            //ArrayList arrayList = new ArrayList();
            ////when i use ctor constructor by defult i create array.empty of object 
            //Console.WriteLine($"Count = {arrayList.Count} Capacity = {arrayList.Capacity}");
            //arrayList.Add( 1 ); // Boxing
            //Console.WriteLine($"Count = {arrayList.Count} Capacity = {arrayList.Capacity}");
            //// default capacity = 4 
            //arrayList.AddRange(new int[] {2,3,4} );
            //Console.WriteLine($"Count = {arrayList.Count} Capacity = {arrayList.Capacity}");
            //arrayList.Add(5);
            //arrayList.TrimToSize();
            ////Release | delete for Unused byte
            //Console.WriteLine($"Count = {arrayList.Count} Capacity = {arrayList.Capacity}");

            //arrayList.Add("Hamada");
            ////compiler can not enforse type safety
            //foreach (var i in arrayList) // UnBoxing
            //{ Console.WriteLine(i); } 
            //int Result = SumArrayList(arrayList);
            //Console.WriteLine(Result);
            #endregion

            #region Generic List

            //List<int> numbers = new List<int>();
            //Console.WriteLine($"Count = {numbers.Count} Capacity = {numbers.Capacity}");
            //numbers.Add(1);
            //Console.WriteLine($"Count = {numbers.Count} Capacity = {numbers.Capacity}"); 
            //numbers.AddRange(new int[] {2,3,4,5});
            //Console.WriteLine($"Count = {numbers.Count} Capacity = {numbers.Capacity}");
            ////CLR will allocate new array with size double size = 8 
            ////numbers.TrimExcess(); 
            //Console.WriteLine($"Count = {numbers.Count} Capacity = {numbers.Capacity}");

            ////numbers.Add("Hamadaa");
            ////compiler can enforce type safety

            //numbers[2] = 5;
            //numbers[4] = 100;  // use indexer as update 

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Method OF List
            //List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,110 };
            //numbers = Enumerable.Range(1, 10).ToList();
            //numbers.Insert(0,101);
            //int index = numbers.BinarySearch(7);
            //List<string> list = new List<string>() {"mostafa","mohamed","afify" };
            //list.Sort();
            //foreach (string i in list) { Console.WriteLine(i); }
            //int index1 = list.BinarySearch("mostafa");
            //Console.WriteLine(index1);
            //Console.WriteLine(index);
            //foreach (int i in numbers) 
            //{ Console.WriteLine(i); }
            //numbers.Clear();
            //Console.WriteLine($"Count = {numbers.Count} Capacity = {numbers.Capacity}");
            //int[] arr = numbers.ToArray();
            //for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
            //int[] arr = new int[11];
            //numbers.CopyTo(2,arr,2,7);
            //for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
            //numbers.EnsureCapacity(20);
            //Console.WriteLine($"Count = {numbers.Count} Capacity = {numbers.Capacity}");
            //Console.WriteLine(numbers.IndexOf(2));


            #endregion

            #region LinkedList [Generic]
            ////list of nodes not sequance
            //LinkedList<int> list = new LinkedList<int>();
            //Console.WriteLine($"Count = {list.Count}");
            //list.AddFirst(1);
            //list.AddLast(3);
            //LinkedListNode<int> node;
            //node = list.Find(1);
            //list.AddAfter(node , 2 );
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generic-Stack

            //Stack<int> stack = new Stack<int>();
            ////array of T[]
            //// last IN First Out 
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Peek();// return element in top without removing it
            //Console.WriteLine(stack.Peek());//4
            //Console.WriteLine(stack.Pop());//return element in top and removing it
            //Console.WriteLine(stack.Peek());


            #endregion

            #region Generic-Queue

            //Queue<int> queue = new Queue<int>();
            ////array Of T[]
            ////have head and tail like [row] first in first out , last in last out
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Dequeue();//1  return  element at start then remove it
            //queue.Peek(); // return element at start without remove it

            #endregion

            #region HashTable [Non-Generic]

            // Pair of key , Value
            //Hashtable PhoneBook = new Hashtable();
            //PhoneBook.Add("mostafa" , 0132);
            //PhoneBook.Add("mohamed" , 0123);  // key is Unique any Operation is O(1)
            //string n = "mostafa";
            //Console.WriteLine(n.GetHashCode());
            //string n2 = "mostafa";
            //Console.WriteLine(n2.GetHashCode());

            ///can not enforce type safety





            #endregion

            #region Dictionary [Generic-HashTable]

            ////All object on Dictionary is a Pair of Key , Value
            //// can enforce type safety
            //// hashtable make smaller collection called [Bucket] 
            //Dictionary<string,int> PhoneBook = new Dictionary<string,int>();
            //PhoneBook.Add("mostafa", 456);
            //PhoneBook.Add("mohamed", 232);
            ////retrive on O(1)
            //if (PhoneBook.ContainsKey("mostafa") == false)
            //    PhoneBook.Add("mostafa", 456);
            //else
            //    PhoneBook["mostafa"] = 999; // update 

            //if(PhoneBook.TryAdd("mostafa", 999) == false)
            //    PhoneBook["mostafa"] = 888;

            //PhoneBook.TryGetValue("mostafa", out int x);
            //Console.WriteLine(x);
            //foreach (KeyValuePair<string , int> person in PhoneBook)
            //{
            //    Console.WriteLine(person.Key);
            //    Console.WriteLine(person.Value);
            //}


            #endregion

            #region PART 02   1.You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList numbers = new ArrayList(new int[] {1,2,3,4,5,6,7,8,9,888});

            //ReverseArrayList(numbers);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region PART 02   2.You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> list = new List<int>();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 16, 22 });

            //evenNumbersOnList(list);
            //List<int> newList = evenNumbersOnList(list);
            //foreach (int i in newList)
            //    Console.WriteLine(i);


            #endregion

            #region PART 02   3.implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.

            //FixedSizeList<int> fixedSize = new FixedSizeList<int>(10);
            //fixedSize.Add(10);
            //fixedSize.Add(20);
            //fixedSize.Add(30);
            //fixedSize.Add(40);
            //fixedSize.Add(50);
            //fixedSize.Add(60);
            //fixedSize.Add(70);
            //fixedSize.Add(80);
            //fixedSize.Add(90);
            //fixedSize.Add(100);
            //fixedSize.Add(110);
            //fixedSize[10] = 999;
            ////Console.WriteLine(fixedSize[10]);
            ////Console.WriteLine(fixedSize.CapacityOfList);


            //fixedSize.ToString();


            #endregion

            #region PART 02   4.Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary

                              ////as i understand the Question
            //string st = "aaaaaaaaakkll";
            //char[] test = st.ToCharArray();
            //int indexer = 1;
            //for (int i = 0; i < test.Length; i++)
            //{
            //    if (test[i] == test[indexer])
            //        { indexer++; }
            //    else
            //    { 
            //        Console.WriteLine(indexer);
            //        break;
            //    }
               
            //}
           

            #endregion


        }
    }
}
