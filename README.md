# CustomList
- operator
   syntax:       Public Static GenericList<T> listsC = listA - listB;   
Parameter: None
Return Type: None 
Example:
using System;
using System.Collections.Generic;

	public void CheckMinusTwoLists()
        {            
            GenericList<string> fish = new GenericList<string>(); // Creates 2 lists
            GenericList<string> dog = new GenericList<string>();
            GenericList<string> newList = new GenericList<string>();
            string expected = "Clownfish";
            string actual;

            fish.Add("Goldfish");
            fish.Add("Clownfish");
            dog.Add("Goldfish");

            //Act
            newList = dog - fish;
            actual = newList[0];;
        }
Output: Goldfish,Clownfish


