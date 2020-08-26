using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Interfaces;
using System; 
namespace BusinessRuleCoreEngine.Implementations.Notifications
{
    public class NotifyEmail : IRuleEngine
    {
        #region Private Members
        private readonly IRuleEngine _ruleEngine = null;
        #endregion
        public NotifyEmail(IRuleEngine ruleEngine=null)
        {
            this._ruleEngine = ruleEngine;
        }

        public Response RuleEngineProcess(string item)
        {
            string errorMsg = "Fail to send email notification";
            try
            {
                Console.WriteLine(item + "\nSent an email to the activated user"); 
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
