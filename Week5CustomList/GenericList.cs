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
        private T[] items; //my array of items
        int count; //creating a variable of count
        int capacity; //creating a variable of capacity
                      // Count property (create this later)


        public GenericList() //constructor
        {
            count = 0; //starting my count at 0
            capacity = 4; //list have a capacity of 0
            items = new T[capacity]; //instanciating my array of items as the capacity 
        }

        //create .Add
        public void Add(T itemToAdd)    //T itemToAdd means T can be anything and will be instanciate once i call this method
        {
            if (CheckCapacity(itemToAdd)) //
            {
                // this means there is already room
                items[count] = itemToAdd; //items to add will now be added to the end of the array
                count++; //adds it at the end
            }
            else
            {
                // this means we need to make room
                T[] tempArray; //temp array of items
                capacity *= 2; //double the capacity
                tempArray = new T[capacity]; //instanciate the array of the size of the capacity 

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i]; //loops through each element in count
                }

                tempArray[count] = itemToAdd; //adds the item to add to count
                count++; //adds it at the end


                items = tempArray; //items now equal new array

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

        //create .Remove
        public bool Remove(T itemToRemove)//T can be anything, needs to be a bool
        {
            if (CheckCapacity(itemToRemove))
            {
                items[count] = itemToRemove; //at the end of items (count) will be removed
                count--; //removes it from the end 
                return true;
            }
            else
            {
                return false;
                //if there is nothing to remove throw exception
            }
        }

        //indexer
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; } //needed to add this so user can grab from a certain index
        }

        


        //public double Calculate(double firstNumber, double secondNumber)
        //{
        //    double sum = firstNumber + secondNumber;
        //    return sum;
        //}

        //public double MultiplySomeNumbers(double firstNumber, double secondNumber)
        //{
        //    double answer = firstNumber * secondNumber;
        //    return answer;
        //}
    }
}
