using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Interfaces;
using System; 

namespace BusinessRuleCoreEngine.Implementations.Notifications
{
    public class PhysicalProductPackingSlip : IRuleEngine
    {
        #region Private Members
        private readonly IRuleEngine _ruleEngine = null;
        #endregion
        public PhysicalProductPackingSlip(IRuleEngine ruleEngine = null)
        {
            this._ruleEngine = ruleEngine;
        }

        public Response RuleEngineProcess(string item = null)
        {
            string errorMsg = "Faild to process physical product packing slip";
            try
            {
                Console.WriteLine(item + "\nfor the physical product packiong slip will be given.");

                if (_ruleEngine != null)
                { 
                    return _ruleEngine.RuleEngineProcess(item);
                }
                return new Response((int)StatusCode.Ok, item);
            }
            catch (Exception e)
            {
                errorMsg = e.Message.ToString();
            }

            return new Response((int)StatusCode.BadRequest, errorMsg);
        }
    }
}
