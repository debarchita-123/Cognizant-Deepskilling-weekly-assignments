using NUnit.Framework;
using Moq;
using CustomerCommLib;

[TestFixture]
public class CustomerCommTests
{
    private Mock<IMailSender> _mockMailSender;
    private CustomerComm _customerComm;

    [OneTimeSetUp]
    public void Init()
    {
        _mockMailSender = new Mock<IMailSender>();
        _customerComm = new CustomerComm(_mockMailSender.Object);
    }

    [Test]
    public void SendMailToCustomer_ShouldReturnTrue()
    {
        // Arrange
        _mockMailSender.Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

        // Act
        var result = _customerComm.SendMailToCustomer();

        // Assert
        Assert.That(result);
    }
}
