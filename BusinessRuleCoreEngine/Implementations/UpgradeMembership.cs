using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Interfaces;
using System; 

namespace BusinessRuleCoreEngine.Implementations
{
    public class UpgradeMembership : IRuleEngine
    {
        #region Private Members
        private readonly IRuleEngine _ruleEngine = null;
        #endregion

        #region Constructors
        public UpgradeMembership(IRuleEngine ruleEngine = null)
        {
            this._ruleEngine = ruleEngine;
        }
        #endregion

        public Response RuleEngineProcess(string item = null)
        {
            string errorMsg = "Faild to upgrade membership";

            try
            { 
                if (_ruleEngine != null)
                { 
                    return _ruleEngine.RuleEngineProcess();
                }
                return new Response((int)StatusCode.Ok);
            }
            catch (Exception e)
            {
                errorMsg = e.Message.ToString();

            }

            return new Response((int)StatusCode.BadRequest, errorMsg);
        }
    }
}
