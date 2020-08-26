using BusinessRuleCoreEngine.CommonUtils;
using BusinessRuleCoreEngine.Interfaces;
using System; 

namespace BusinessRuleCoreEngine.Implementations
{
   public class CreateDuplicateSlipForRoyaldepartment : IRuleEngine
    {
        #region Private Members
        private readonly IRuleEngine _ruleEngine = null;
        #endregion

        #region Constructors
        public CreateDuplicateSlipForRoyaldepartment(IRuleEngine ruleEngine = null)
        {
            this._ruleEngine = ruleEngine;
        }
        #endregion

        #region Public Functions
        public Response RuleEngineProcess(string item = null)
        {
            string errorMsg = "Faild to creating packing slip for royalty department";

            try
            { 
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
        #endregion
    }
}
