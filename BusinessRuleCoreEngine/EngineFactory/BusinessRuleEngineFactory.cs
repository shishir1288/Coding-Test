using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Implementations;
using BusinessRuleCoreEngine.Implementations.Notifications; 

namespace BusinessRuleCoreEngine.EngineFactory
{
    public class BusinessRuleEngineFactory
    {
        public Response RunBusinessRules(PaymentType type)
        { 
            switch (type)
            {
                case PaymentType.PHYSICAL_PRODUCT:
                    {
                        var createCommissionPayment = new ProcessCommissionPayment();
                        var packingSlip = new PhysicalProductPackingSlip(createCommissionPayment);
                        return packingSlip.RuleEngineProcess();
                    }
                case PaymentType.BOOK:
                    {
                        var createCommissionPayment = new ProcessCommissionPayment();
                        var GeneratePackingSlipForRoyaltyDepartment = new CreateDuplicateSlipForRoyaldepartment(createCommissionPayment);
                        return GeneratePackingSlipForRoyaltyDepartment.RuleEngineProcess();
                    }
                case PaymentType.MEMBERSHIP_ACTIVATE:
                    {
                        var sendEmailNotifification = new NotifyEmail();
                        var activateMemberShip = new ActivateMemeberShip(sendEmailNotifification);
                        return activateMemberShip.RuleEngineProcess();
                    }
                case PaymentType.MEMBERSHIP_UPGRADE:
                    {
                        var sendEmailNotifification = new NotifyEmail();
                        var applyUpgrade = new UpgradeMembership(sendEmailNotifification);
                        return applyUpgrade.RuleEngineProcess();
                    }
                case PaymentType.VIDEO:
                    {
                        var addFirstAidVideo = new AddFirstAidVideo();
                        var packingSlip = new PhysicalProductPackingSlip(addFirstAidVideo);
                        return packingSlip.RuleEngineProcess();
                    }
                default:
                    return new Response((int)StatusCode.BadRequest, "payment type is not found");
            }
        }
    }
}
