using SkySwordKill.Next.DialogSystem;

namespace SkySwordKill.NextCommandExamplePlugin
{
    /// <summary>
    /// 自定义查询指令参考范例
    /// 通过继承IDialogEnvQuery接口编写查询指令
    /// 使用 [DialogEnvQuery("CheckFamilyName")] 可以将查询指令函数绑定到Env之中
    /// 在Next初始化时会自动注册
    /// 也可以使用 <code>DialogAnalysis.RegisterEnvQuery("CostMoney",new CheckFamilyNameQuery());</code> 手动注册
    /// </summary>
    [DialogEnvQuery("CheckFamilyName")]
    public class CheckFamilyNameQuery : IDialogEnvQuery
    {
        public object Execute(DialogEnvQueryContext context)
        {
            var familyName = context.GetArg<string>(0);
            if(string.IsNullOrEmpty(familyName))
            {
                return false;
            }
            
            return context.Env.player.firstName == familyName;
        }
    }
}