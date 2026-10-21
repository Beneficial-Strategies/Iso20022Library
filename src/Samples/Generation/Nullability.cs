// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Samples;

/// <summary>Whether a member of an interface is optional, read from the nullable annotations the compiler writes (the same on every target).</summary>
internal static class Nullability
{
    private const string NullableAttribute = "System.Runtime.CompilerServices.NullableAttribute";
    private const string NullableContextAttribute = "System.Runtime.CompilerServices.NullableContextAttribute";

    /// <summary>True for <c>Max35Text?</c> and <c>IGroupHeader104?</c>, false for the same without the question mark.</summary>
    internal static bool IsOptional(PropertyInfo property)
    {
        if (Nullable.GetUnderlyingType(property.PropertyType) is not null)
            return true;
        if (property.PropertyType.IsValueType)
            return false;
        var own = Flag(property.CustomAttributes, NullableAttribute);
        if (own is not null)
            return own == 2;
        for (var type = property.DeclaringType; type is not null; type = type.DeclaringType)
        {
            var context = Flag(type.CustomAttributes, NullableContextAttribute);
            if (context is not null)
                return context == 2;
        }
        return false;
    }

    private static byte? Flag(IEnumerable<CustomAttributeData> attributes, string name)
    {
        var attribute = attributes.FirstOrDefault(a => a.AttributeType.FullName == name);
        if (attribute is null || attribute.ConstructorArguments.Count == 0)
            return null;
        var argument = attribute.ConstructorArguments[0].Value;
        if (argument is byte single)
            return single;
        // an array of flags: the first is the member itself, the rest are its type arguments
        if (argument is IReadOnlyList<CustomAttributeTypedArgument> list && list.Count > 0 && list[0].Value is byte first)
            return first;
        return null;
    }
}
