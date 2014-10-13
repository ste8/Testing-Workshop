using NSubstitute;
using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class HelloTests
    {
        [Test]
        public void FirstPassingTest()
        {
            Assert.True(true);
        }

        [Test]
        public void FirstFailingTest()
        {
            Assert.False(true, "I should fail!!");
        }

        [Test]
        public void StubTestWithNSubstitute()
        {
            //Arrange
            var service = Substitute.For<IWeatherService>();
            service.GetWeather("Rome").Returns("Sunny");
            service.GetWeather("Cortina").Returns("Snowy");

            //Act
            var actual = service.GetWeather("Rome");

            //Assert
            Assert.AreEqual("Sunny", actual);
        }

        [Test]
        public void MockTestWithNSubstitute()
        {
            //Arrange
            var service = Substitute.For<IWeatherService>();
            service.GetWeather("Rome").Returns("Sunny");
            service.GetWeather("Cortina").Returns("Snowy");

            //Act
            var actual = service.GetWeather("Rome");

            //Assert
            Assert.AreEqual("Sunny", actual);

            service.Received().GetWeather("Rome");
            service.DidNotReceive().GetWeather("Cortina");
        }
    }
}