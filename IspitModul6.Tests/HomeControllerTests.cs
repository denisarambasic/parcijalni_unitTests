using IspitModul6.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IspitModul6.Tests;

public class HomeControllerTests
{

    [Fact]
    public void CheckCountValue_WhenInputValueIsGreaterOrEqual20_ThrowsException()
    {
        //Arrange
        var controller = new HomeController();

        //Act
        var exception = Assert.Throws<Exception>(() => controller.CheckCountValue(500));

        //Assert
        Assert.Equal("Broj je izvan raspona", exception.Message);
    }

    [Fact]
    public void CheckCountValue_ReturnsViewResult()
    {
        //Arrange
        var controller = new HomeController();

        //Act
        var result = controller.CheckCountValue(2);

        //Assert
        Assert.IsType<ViewResult>(result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void CheckCountValue_ReturnsViewResult_ForVariousInputs(int i)
    {
        //Arrange
        var controller = new HomeController();

        //Act
        var result = controller.CheckCountValue(i);

        //Assert
        Assert.IsType<ViewResult>(result);
    }
}
