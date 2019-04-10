using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week5CustomList;

namespace CustomListUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]//adding a string to a list 
        public void TestMethod1()
        {
            //Arrange
            GenericList<string> myList = new GenericList<string>();
            string value = "Deja";

            //Act
            myList.Add(value);

            //Assert
            //Assert.AreEqual(value, myList[0]);
        }

        //[TestMethod]//adding a deja to the list 3 times
        //public void TestMethod2()
        //{
        //    //Arrange
        //    GenericList<string> myList = new GenericList<string>();
        //    string value = "Deja";


        //    //Act
        //    myList.Add(value);
        //    myList.Add(value);
        //    myList.Add(value);

        //    //Assert
        //    Assert.AreEqual(value, myList[0]); //error because I haven't created index yet
        //}


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

        //[TestMethod]
        //public void CheckAdd1()
        //{
        //    GenericList<string> animals = new GenericList<string>();
        //    string firstAnimal = "Tiger";
        //    string secondAnimal = "Duck";
        //    string thirdAnimal = "Cat";
        //    string fourthAnimal = "Ant";
        //    string expectedResult = ("Tiger","Duck", "Cat", "Ant");
        //    // int result = animals.Count;
        //    int result;

        //    animals.Add(firstAnimal);
        //    animals.Add(secondAnimal);
        //    animals.Add(thirdAnimal);
        //    animals.Add(fourthAnimal);
        //    // add the adds (lol)


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
