namespace PAC.Tests.WebApi;
using System.Collections.ObjectModel;

using System.Data;
using Moq;
using PAC.IBusinessLogic;
using PAC.Domain;
using PAC.WebAPI;
using Microsoft.AspNetCore.Mvc;

[TestClass]
public class StudentControllerTest
{
    private Mock<IStudentLogic>? _studentMock;
    private StudentController? _controller;

    [TestInitialize]
    public void InitTest()
    {
        _studentMock = new Mock<IStudentLogic>(MockBehavior.Strict);
        _controller = new StudentController(_studentMock.Object);
    }

    [TestMethod]
    public void PostStudentOk() 
    {
        var student = new Student();
        var result = _controller!.Post(student) as ObjectResult;

        _studentMock!.VerifyAll();
        Assert.AreEqual(200, result.StatusCode);
    }
}
