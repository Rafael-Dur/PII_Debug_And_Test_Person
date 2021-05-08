using NUnit.Framework;
using UnitTestAndDebug;


namespace UnitTestAndDebug
{
    public class Tests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            //Arrange
            this.person = new Person("John Doe", "1.234.567-8");

        }

        [Test]
        public void NameNotNull()
        {
            Assert.IsNotNull(person.Name);
        }

        [Test]
        public void NameCannotBeEmpty()
        {
            //Act
            person.Name = "";
            //Assert
            Assert.IsNotEmpty(person.Name);
        }

        [Test]
        public void ChangeName() 
        {
            //Act
            person.Name = "Ramón";
            //Assert
            Assert.AreEqual("Ramón", person.Name);
        }

        [Test]
        public void ValidateEmptyID() 
        {
            //Act
            person.ID = "";
            //Assert
            Assert.AreEqual("", person.ID);
        }
    }
}