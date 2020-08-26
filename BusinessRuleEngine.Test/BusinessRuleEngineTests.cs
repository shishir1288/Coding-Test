using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.EngineFactory;
using BusinessRuleCoreEngine.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusinessRuleEngine.Test
{
    [TestClass]
    public class BusinessRuleEngineTests
    {
        private readonly BusinessRuleEngineFactory businessRuleEngineFactory;
        private readonly Mock<BusinessRuleEngineFactory> mockbusinessRuleEngineFactory;
        private Mock<Response> mockResponce;
        private Mock<IRuleEngine> mockIRuleEngine;
        public BusinessRuleEngineTests()
        {
            businessRuleEngineFactory = new BusinessRuleEngineFactory();
            mockbusinessRuleEngineFactory = new Mock<BusinessRuleEngineFactory>();
            mockResponce = new Mock<Response>();
            mockIRuleEngine = new Mock<IRuleEngine>();

        }
        [TestMethod]
        public void Test_Book_Success()
        {
            mockIRuleEngine.Setup(x => x.RuleEngineProcess(null)).Returns(mockResponce.Object);
            var ret = businessRuleEngineFactory.RunBusinessRules(PaymentType.BOOK);
            Assert.IsTrue(ret.Status == (int)StatusCode.Ok);
        }
        [TestMethod]
        public void Test_Physical_Product_Success()
        {
            mockIRuleEngine.Setup(x => x.RuleEngineProcess(null)).Returns(mockResponce.Object);
            var ret = businessRuleEngineFactory.RunBusinessRules(PaymentType.PHYSICAL_PRODUCT);
            Assert.IsTrue(ret.Status == (int)StatusCode.Ok);
        }
        [TestMethod]
        public void Test_Physical_Membership_Activate_Success()
        {
            mockIRuleEngine.Setup(x => x.RuleEngineProcess(null)).Returns(mockResponce.Object);
            var ret = businessRuleEngineFactory.RunBusinessRules(PaymentType.MEMBERSHIP_ACTIVATE);
            Assert.IsTrue(ret.Status == (int)StatusCode.Ok);
        }
        [TestMethod]
        public void Test_Physical_Membership_Upgrade_Success()
        {
            mockIRuleEngine.Setup(x => x.RuleEngineProcess(null)).Returns(mockResponce.Object);
            var ret = businessRuleEngineFactory.RunBusinessRules(PaymentType.MEMBERSHIP_UPGRADE);
            Assert.IsTrue(ret.Status == (int)StatusCode.Ok);
        }
        [TestMethod]
        public void Test_Physical_Membership_Video_Success()
        {
            mockIRuleEngine.Setup(x => x.RuleEngineProcess(null)).Returns(mockResponce.Object);
            var ret = businessRuleEngineFactory.RunBusinessRules(PaymentType.VIDEO);
            Assert.IsTrue(ret.Status == (int)StatusCode.Ok);
        }
    }
}
