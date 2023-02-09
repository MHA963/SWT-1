using Calculator;

namespace Calculator.Test.Unit
{

    [TestFixture]
    public class CalculatorTests
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        [Test]
        public void Add_GivenTwoNumbers_shouldReturnTheirSum()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Add(2,3),Is.EqualTo(5));

        }

        [Test]
        public void Subtract_GiventwoNumbers_ShouldReturnTheirDifference()
        {
            //Arrange


            //Act
            
            //Assert
            Assert.That(uut.Substract(3,2), Is.EqualTo(1));

        }
        [Test]

        public void Multiply_givenTwoNumbers_ShouldReturnTheirMultiple()
        {

            //Arrange
            //Act
            
            //Assert
            Assert.That(uut.Multiply(3, 2), Is.EqualTo(6));
        }

        [Test]
        public void Power_givenTwoNumbers_ShouldReturnValue()
        {


            //Arrange
            //Act
            //Assert
            Assert.That(uut.Power(3,2), Is.EqualTo(9));

        }
        [Test]

        public void Divide_givenTwoNumbers_ShouldReturnAValue()
        {

            Assert.That(uut.divide(6, 6), Is.EqualTo(1));
        
        }
     


    }
}