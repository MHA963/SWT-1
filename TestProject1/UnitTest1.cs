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
            uut.Add(2, 3);
            //Assert
            Assert.AreEqual(5,uut.Accumulator);

        }

        [Test]
        public void Subtract_GiventwoNumbers_ShouldReturnTheirDifference()
        {
            //Arrange


            //Act
            uut.Substract(3, 2);
            //Assert

            Assert.AreEqual(1, uut.Accumulator);
        }
        [Test]

        public void Multiply_givenTwoNumbers_ShouldReturnTheirMultiple()
        {

            //Arrange
            //Act
            uut.Multiply(3, 2);
            //Assert
            Assert.AreEqual(6, uut.Accumulator);
        }

        [Test]
        public void Power_givenTwoNumbers_ShouldReturnValue()
        {


            //Arrange
            //Act
            uut.Power(3, 2);
            //Assert
            Assert.AreEqual(9,uut.Accumulator);

        }
        [Test]

        public void Divide_givenTwoNumbers_ShouldReturnAValue()
        {
            uut.divide(6, 6);

            Assert.AreEqual(1,uut.Accumulator);
        
        }

        [Test]

        public void Clear_ShouldReturnValueOfZero()
        {

            uut.Clear();
            Assert.AreEqual(0, uut.Accumulator);
        }
        

    }
}