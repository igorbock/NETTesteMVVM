using EntityFrameworkLib.Context;
using Microsoft.EntityFrameworkCore.Metadata;
using Moq;
using VisualBasicLib.Abstracts;
using VisualBasicLib.Interfaces;

namespace NETTesteMVVM.Abstracts;

public class LoginTests
{
    private Mock<LoginAbstract> _mockLogin;
    private Mock<INavigationManager> _mockNavigation;
    private Mock<LibDbContext> _mockContext;

    [SetUp]
    public void Setup()
    {
        _mockNavigation = new Mock<INavigationManager>();
        _mockContext = new Mock<LibDbContext>();
        _mockLogin = new Mock<LoginAbstract>(_mockNavigation.Object, _mockContext.Object);
    }

    [Test]
    public void HashPasswordTest()
    {
        var login = _mockLogin.Object;
        var hashPassword = login.HashPassword("teste", [0,1,1,0]);
        var isCorrect = login.VerifyPassword("teste", hashPassword, [0, 1, 1, 0]);

        Assert.IsTrue(isCorrect);
        Assert.Pass();
    }
}
