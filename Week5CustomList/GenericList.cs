using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CustomList
{
    public class GenericList<T>//when I instanciate this class I need to give it the datatype of what I want the class to be
    {
        //member variables
        private T[] items;
        int count;
        int capacity;
        // Count property
        // indexer property (google this one)

        public GenericList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        //create .Add
        public void Add(T itemToAdd)
        {
            if (CheckCapacity(itemToAdd))
            {
                // this means there is already room
                items[count] = itemToAdd;
                count++;
            }
            else
            {
                T[] tempArray;
                // this means we need to make room
                capacity *= 2;
                tempArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                
                tempArray[count] = itemToAdd;
                count++;


                items = tempArray;

            }
            
        }

        //checks capacity 
        private bool CheckCapacity(T item)
        {
            if (count < capacity)
            {
                return true;
            }
            else
            {
                //add another array
                return false;
            }
        }

        //increase capacity
        private void IncreaseCapacity()
        {

        }

        //create .remove
        public void Remove(T item)
        {
            if (CheckCapacity(item))
            {
              
            }
            else
            {

            }
            //for (int i = 0; i < item; i++)
            //{

            //}
        }




        public double Calculate(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            return sum;
        }

        public double MultiplySomeNumbers(double firstNumber, double secondNumber)
        {
            double answer = firstNumber * secondNumber;
            return answer;
        }


        //public void Add(string firstAnimal, string secondAnimal, string thirdAnimal, string fourthAnimal)
        //{
        //    for (int i = 0; i < length; i++)
        //    {

        //    }
        //}
    }
}
