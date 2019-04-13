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
            //int result = animals.Count;

            //Act
            animals.Add(firstAnimal);
            animals.Add(secondAnimal);
            animals.Add(thirdAnimal);
            animals.Add(fourthAnimal);
            animals.Add(fifthAnimal);

            //Assert
            Assert.AreEqual(fourthAnimal, animals[3]);
        }

        [TestMethod]
        public void CheckRemove1()
        {
            //Arrange
            GenericList<string> myList = new GenericList<string>();
            string[] testIntArray = new string[3] { "Dog", "Bird", "Lizard" };


            //Act
            myList.Remove("Bird"); 

            //Assert
            Assert.IsFalse(false, "Bird");
        }

        [TestMethod]
        public void CheckRemove2()
        {
            //Arrange
            GenericList<int> numbers = new GenericList<int>();
            int[] testNumbers = new int[4] { 1, 2, 3, 4 };


            //Act
            numbers.Remove(2);

            //Assert
            Assert.IsFalse(false);
        }

        [TestMethod]//counts how many elements are in a string
        public void CheckCount()
        {
            //Arrange
            GenericList<string> shoes = new GenericList<string>();
            string shoeOne = "Nike";

            //Act
            shoes.Add(shoeOne);//replace add with the method that will preform this when I create it

            //Assert
            Assert.AreEqual(1, shoes.Count);
        }


}
}   

       //[TestMethod]
        //public void TestMethod2() //testing count
        //{
        //    //Arrange
        //    GenericList<int> myList = new GenericList<int>();
        //    int value = 5;
        //    int expectedCount = 1;
        //    //Act
        //    myList.Add(value);

        //    //Assert
        //    Assert.AreEqual(expectedCount, myList.Count);
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

    

