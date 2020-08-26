using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Interfaces;
using System;

namespace BusinessRuleCoreEngine.Implementations
{
    public class ActivateMemeberShip : IRuleEngine 
    {
        #region Private Members
        private readonly IRuleEngine _ruleEngine = null;
        #endregion
        public ActivateMemeberShip(IRuleEngine ruleEngine=null)
        {
            this._ruleEngine = ruleEngine;
        }

        public Response RuleEngineProcess(string item=default)
        {
            string errorMsg = "Faild to activate membership";
            try
            {
                if (_ruleEngine != null)
                {
                    item = "Dear User, Your Membership has been activated ";
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
