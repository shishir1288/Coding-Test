
using BusinessRuleCoreEngine.CommonUtils;

namespace BusinessRuleCoreEngine.Interfaces
{
    /// <summary>
    /// Generic interface can be create as user defined
    /// </summary> 
    public interface IRuleEngine
    {
        Response RuleEngineProcess(string item = default);
    }
}
