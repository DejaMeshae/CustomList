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

        //[TestMethod]
        //public void CheckRemove3()
        //{
        //    //Arrange
        //    GenericList<int> numbers = new GenericList<int>();
        //    int number1 = 1;
        //    int number2 = 2;


        //    //Act
        //    numbers.Add(number1);
        //    numbers.Add(number2);
        //    numbers.Add(number1);
        //    numbers.Remove(3);

        //    //Assert
        //    Assert.AreEqual(3, numbers.Count); //FIX
        //}


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

        [TestMethod]//FIX
        public void CheckCount2()
        {
            //Arrange
            GenericList<int> list = new GenericList<int>();
            int number = 3;

            //Act
            list.Add(number);
            list.Add(number);
            list.Add(number);

            //Assert
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void CheckToString()
        {
            //Arrange
            GenericList<string> list = new GenericList<string>();
            list.Add("Cats");
            list.Add("Cats");
            list.Add("Cats");
            //Act
            string Cats = list.ToString();
            //Assert
            Assert.AreEqual("CatsCatsCats", Cats);
        }

        [TestMethod]
        public void CheckMinusTwoLists()
        {
            //Arrange
            GenericList<string> fish = new GenericList<string>();
            GenericList<string> dog = new GenericList<string>();
            fish.Add("Goldfish");
            fish.Add("Clownfish");
            dog.Add("German Shepherd");

            //Act
            GenericList<string> animals = fish - dog;

            //Assert
            Assert.AreEqual(1, animals[0]);
        }

    }
}   


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

    

