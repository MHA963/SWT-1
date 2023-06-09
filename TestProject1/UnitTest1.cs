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
        public void Add_GivenTwoPositiveIntegers_shouldReturnTheirSum()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Add(2,3),Is.EqualTo(5));

        }
        [Test]
        public void Add_GivenTwoMixedIntegers_shouldReturnTheirSum()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Add(-2,-3), Is.EqualTo(-5));

        }
        [Test]
        public void Add_GivenTwoNegativeIntegers_shouldReturnTheirSum()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Add(-2, 3), Is.EqualTo(1));

        }
        [Test]
        public void Add_GivenTwoDecimals_shouldReturnTheirSum()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Add(0.2, 0.51), Is.EqualTo(0.71));

        }


        [Test]
        public void Subtract_GivenTwoPositiveIntegers_ShouldReturnTheirDifference()
        {
            //Arrange


            //Act
            uut.Substract(3, 2);
            //Assert

            Assert.AreEqual(1, uut.Accumulator);
        }
        [Test]
        public void Subtract_GivenTwoMixedIntegers_ShouldReturnTheirDifference()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Substract(-3, 2), Is.EqualTo(-5));

        }
        [Test]
        public void Subtract_GivenTwoNegativeIntegers_ShouldReturnTheirDifference()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Substract(-3, -2), Is.EqualTo(-1));

        }
        [Test]
        public void Subtract_GivenTwoDecimals_ShouldReturnTheirDifference()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(uut.Substract(0.4,0.2), Is.EqualTo(0.2));

        }


        [Test]
        public void Multiply_GivenTwoPositiveIntegers_ShouldReturnTheirMultiple()
        {

            //Arrange
            //Act
            //Assert
            Assert.That(uut.Multiply(3, 2), Is.EqualTo(6));
        }
        [Test]
        public void Multiply_GivenTwoMixedIntegers_ShouldReturnTheirMultiple()
        {

            //Arrange
            //Act
            //Assert
            Assert.That(uut.Multiply(3, -2), Is.EqualTo(-6));
        }
        [Test]
        public void Multiply_GivenTwoNegativeIntegers_ShouldReturnTheirMultiple()
        {

            //Arrange
            //Act
            //Assert
            Assert.That(uut.Multiply(-3, -2), Is.EqualTo(6));
        }
        [Test]
        public void Multiply_GivenTwoDecimals_ShouldReturnTheirMultiple()
        {

            //Arrange
            //Act
            //Assert
            Assert.That(uut.Multiply(0.3, 0.5), Is.EqualTo(0.15));
        }
        [Test]
        public void Power_givenTwoPositiveIntegers_ShouldReturnValue()
        {

            //Arrange
            //Act
            //Assert
            Assert.That(uut.Power(3, 2), Is.EqualTo(9));
        }
        [Test]
        public void Power_GivenNegativeInteger_And_NegativeExponetial_ShouldReturnValue()
        {

            //Arrange
            var a = -2;
            var b = -3;

            var expectedresult = -0.125;
            //Act
            var result = uut.Power(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(expectedresult));

        }
        [Test]
        public void Power_GivenPositiveInteger_And_NegativeExponetial_ShouldReturnValue()
        {

            //Arrange
            //Act
            //Assert
            Assert.That(uut.Power(2, -3), Is.EqualTo(0.125));

        }
        [Test]

        public void Divide_givenTwoPositiveNumbers_ShouldReturnAValue()
        {
            uut.divide(6, 6);

            Assert.AreEqual(1, uut.Accumulator);
        }

        [Test]

        public void Divide_GivenOneNegativeNumber_ShouldReturnAValue()
        {
            uut.divide(-6, 6);

            Assert.AreEqual(-1, uut.Accumulator);
        }

        [Test]

        public void Divide_GivenTwoNegativeNumbers_ShouldReturnAValue()
        {
            uut.divide(-6, -6);

            Assert.AreEqual(1, uut.Accumulator);
        }

        [Test]

        public void Clear_ShouldPowerReturnValueOfZero()
        {
            //Arrange
            var a = -2;
            var b = -3;

            var expectedresult = -0.125;
            //Act
            var result = uut.Power(a, b);
            uut.Clear();
            //Assert
            Assert.AreEqual(0, uut.Accumulator);
        }

        [Test]
        public void Clear_ShouldAddReturnValueOfZero()
        {
            var a = 2;
            var b = 3;

            var expectedresult = 5;
            //Act
            var result = uut.Add(a, b);
            uut.Clear();
            //Assert
            Assert.AreEqual(0, uut.Accumulator);
        }
        public void Clear_ShouldSubtractReturnValueOfZero()
        {
            var a = 2;
            var b = 3;

            var expectedresult = -1;
            //Act
            var result = uut.Substract(a, b);
            uut.Clear();
            //Assert
            Assert.AreEqual(0, uut.Accumulator);
        }
    }
    }
