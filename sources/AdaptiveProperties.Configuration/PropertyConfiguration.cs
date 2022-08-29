// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CheckNamespace
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable once CheckNamespace

namespace AdaptiveProperties.Configuration;

    public class PropertyConfiguration
    {
        public string ViewType { get; }

        public string PropertyName { get; }

        public string PropertyType { get; }

        public string ApplyActionString { get; }

        public PropertyConfiguration(string viewType, string propertyType, string propertyName,
            string customApplyHandler = null)
        {
            ViewType = viewType;
            PropertyName = propertyName;
            PropertyType = propertyType;

            ApplyActionString =
                customApplyHandler
                //default apply action
                ?? @"(view,value) => { var previousValue = view." + PropertyName + "; view." + PropertyName + " = value; return (true, previousValue); }";
        }
    }