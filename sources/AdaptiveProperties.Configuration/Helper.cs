namespace AdaptiveProperties.Configuration;

internal static class Helper
{
    /// <summary>
    /// Constructor used to create a ModeConfiguration in code
    /// </summary>
    internal static ModeConfiguration CreateModeConfiguration(string name, bool checkFunc, string comment)
    {
        return null;
    }

    /// <summary>
    /// Constructor used to create a ModeConfiguration in code
    /// </summary>
    internal static ModeConfiguration CreateModeConfiguration(string name, string comment)
    {
        return null;
    }

    /// <summary>
    /// Constructor used to create a PropertyConfiguration in code
    /// </summary>
    internal static PropertyConfiguration CreatePropertyConfiguration<TView, TValue>(
        Func<TView, object> property, Func<TView, TValue, (bool, TValue)> customApplyHandler = null)
    {
        return null;
    }

    /// <summary>
    /// Constructor used to create a PropertyConfiguration in code
    /// </summary>
    internal static PropertyConfiguration CreatePropertyConfiguration<TView, TValue>(
        string customPropertyName, Func<TView, TValue, (bool, TValue)> customApplyHandler = null)
    {
        return null;
    }
}