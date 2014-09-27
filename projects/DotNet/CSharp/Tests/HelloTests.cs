﻿using NUnit.Framework;
using Rhino.Mocks;

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
        public void StubTest()
        {
            //Arrange
            var service = MockRepository.GenerateStub<IWeatherService>();
            service.Expect(x => x.GetWeather("Rome")).Return("Sunny");
            service.Expect(x => x.GetWeather("Cortina")).Return("Snowy");

            //Act
            var actual = service.GetWeather("Rome");

            //Assert
            Assert.AreEqual("Sunny", actual);
        }

        [Test]
        public void MockTest()
        {
            //Arrange
            var service = MockRepository.GenerateMock<IWeatherService>();
            service.Expect(x => x.GetWeather("Rome")).Return("Sunny");
            service.Expect(x => x.GetWeather("Cortina")).Return("Snowy");

            //Act
            var actual = service.GetWeather("Rome");

            //Assert
            Assert.AreEqual("Sunny", actual);

            service.AssertWasCalled(x => x.GetWeather("Rome"));
            service.AssertWasNotCalled(x => x.GetWeather("Cortina"));
            //service.VerifyAllExpectations();
        }
    }

    public interface IWeatherService
    {
        string GetWeather(string city);
    }
}
