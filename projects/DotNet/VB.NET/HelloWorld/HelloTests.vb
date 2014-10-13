Imports NUnit.Framework
Imports NSubstitute

<TestFixture>
Public Class HelloTests

    <Test>
    Public Sub FirstPassingTest()
        Assert.True(True)
    End Sub

    <Test>
    Public Sub FirstFailingTest()
        Assert.False(True, "I should fail!!")
    End Sub

    <Test>
    Public Sub StubTestWithNSubstitute()

        'Arrange
        Dim service = Substitute.For(Of IWeatherService)()
        service.GetWeather("Rome").Returns("Sunny")
        service.GetWeather("Cortina").Returns("Snowy")

        'Act
        Dim actual As String = service.GetWeather("Rome")

        'Assert
        Assert.AreEqual("Sunny", actual)
    End Sub

    <Test>
    Public Sub MockTestWithNSubstitute()

        'Arrange
        Dim service = Substitute.For(Of IWeatherService)()
        service.GetWeather("Rome").Returns("Sunny")
        service.GetWeather("Cortina").Returns("Snowy")

        'Act
        Dim actual As String = service.GetWeather("Rome")

        'Assert
        Assert.AreEqual("Sunny", actual)

        service.Received().GetWeather("Rome")
        service.DidNotReceive().GetWeather("Cortina")
    End Sub


End Class


