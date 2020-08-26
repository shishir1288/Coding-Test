using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.EngineFactory;
using System;

namespace BusinessRuleCoreEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating instance of the factroy which run's rule engine
            BusinessRuleEngineFactory businessRuleEngineFactory = new BusinessRuleEngineFactory();
            //right now MEMBERSHIP_ACTIVATE has been setup but as per requirement PaymentType can be changed
            Response response = businessRuleEngineFactory.RunBusinessRules(CommonUtils.PaymentType.MEMBERSHIP_ACTIVATE);
            //based upon response will be updating the status code to the user
            Console.WriteLine(response.Status == 1 ? "Satatus : Ok" : "Satatus : Issue");
            Console.ReadLine();
        }
    }
}
