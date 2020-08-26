using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Interfaces;
using System; 

namespace BusinessRuleCoreEngine.Implementations
{
    public class ProcessCommissionPayment : IRuleEngine
    {
        #region Private Members
        private readonly IRuleEngine _ruleEngine = null;
        #endregion
        public ProcessCommissionPayment(IRuleEngine ruleEngine = null)
        {
            this._ruleEngine = ruleEngine;
        }

        public Response RuleEngineProcess(string item = null)
        {
            string errorMsg = "Fail to generate commission payment";

            try
            {
                Console.WriteLine(item); 
                if (_ruleEngine != null)
                {
                    return _ruleEngine.RuleEngineProcess();
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
