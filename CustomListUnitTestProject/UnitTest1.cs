using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week5CustomList;

namespace CustomListUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]//adding a string to a list, testing the add method
        public void CheckAdd1()
        {
            //Arrange
            GenericList<string> myList = new GenericList<string>();
            string value = "Deja";

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(value, myList[0]); //passed as Deja is now in the index of 0, the first index
        }

        [TestMethod]//adding a deja to the list 4 times, checking the 3rd index
        public void CheckAdd2()
        {
            //Arrange
            GenericList<string> myList = new GenericList<string>();
            string value = "Deja";
            


            //Act
            myList.Add(value);
            myList.Add(value);
            myList.Add(value);
            myList.Add(value);


            //Assert
            Assert.AreEqual(value, myList[3]);
        }

        [TestMethod]//adding different animals to a list, checking the the 3rd index which should be ant
        public void CheckAdd3()
        {
            //Arrange
            GenericList<string> animals = new GenericList<string>();
            string firstAnimal = "Tiger";
            string secondAnimal = "Duck";
            string thirdAnimal = "Cat";
            string fourthAnimal = "Ant";
            string fifthAnimal = "Lion";
            // int result = animals.Count;

            //Act
            animals.Add(firstAnimal);
            animals.Add(secondAnimal);
            animals.Add(thirdAnimal);
            animals.Add(fourthAnimal);
            animals.Add(fifthAnimal);

            //Assert
            Assert.AreEqual(fourthAnimal, animals[3]);
        }

        [TestMethod]//adding a string to a list, testing the add method
        public void CheckRemove1()
        {
            //Arrange
            GenericList<string> myList = new GenericList<string>();
            string value = "Deja"; //creating values
            string value2 = "Joseph";
            string value3 = "Jack";


            //Act
            myList.Add(value); //adding strings to list
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value3); //removing value 3 which is at the 2nd index

            //Assert
            Assert.AreEqual(value3, myList[2]); 
            //Assert.AreNotEqual(value3, myList[2]);
        }



        //[TestMethod]//counts how many elements are in a string
        //public void CheckCount()
        //{
        //    GenericList<string> shoes = new GenericList<string>();
        //    string shoeOne = "Nike";
        //    string shoeTwo = "Addias";
        //    int expectedResult = 2;
        //int result = shoes.Count;

        ////adding the shoes to the list
        //shoes.Add(shoeOne);//replace add with the method that will preform this when I create it
        //shoes.Add(shoeTwo);//replace add "

        //    Assert.AreEqual(expectedResult, result);
        //}


        //[TestMethod]
        //public void CheckCount2()
        //{
        //    GenericList<int> numbers = new GenericList<int>();
        //    int firstNumber = 6;
        //    int secondNumber = 10;
        //    int expectedResult = 16;
        //    int result = numbers.Count;

        //    numbers.Calculate(firstNumber, secondNumber);

        //    Assert.AreEqual(expectedResult, result);
        //}


        //[TestMethod]//adding 2 numbers together
        //public void Add_PositiveNumbers()
        //{
        //    //Arrange
        //    GenericList<double> genericList = new GenericList<double>();
        //    double firstValue = 5;
        //    double secondValue = 10;
        //    double result;
        //    double expectedResult = firstValue + secondValue;

        //    //Act
        //    result = genericList.Calculate(firstValue, secondValue);

        //    //Assert
        //    Assert.AreEqual(expectedResult, result);
        //}

    }
}
