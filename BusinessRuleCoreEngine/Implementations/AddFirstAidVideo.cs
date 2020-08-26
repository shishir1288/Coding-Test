using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Interfaces;
using System; 

namespace BusinessRuleCoreEngine.Implementations
{
   public class AddFirstAidVideo : IRuleEngine
    {
        #region Private Members
        private readonly IRuleEngine _ruleEngine = null;
        #endregion
        public AddFirstAidVideo(IRuleEngine ruleEngine=null)
        {
            this._ruleEngine = ruleEngine;
        }

        public Response RuleEngineProcess(string item=default)
        {
            string errorMsg = "Fail to add first ad video";
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
