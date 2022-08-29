// ReSharper disable CheckNamespace
namespace AdaptiveProperties.Configuration;

public class ModeConfiguration
{
    public string Name { get; }

    public string CheckFuncString { get; }

    public string Comment { get; }
    
    public bool HasCustomActivationCheckingFunc { get; }

    public ModeConfiguration(string name, string checkFuncString, string comment)
    {
        Name = name;
        CheckFuncString = checkFuncString;
        Comment = comment;
    }
    
    public ModeConfiguration(string name, string comment)
    {
        Name = name;
        Comment = comment;
        HasCustomActivationCheckingFunc = true;
        CheckFuncString = "_customActivationCheckingFunc()";
    }
}