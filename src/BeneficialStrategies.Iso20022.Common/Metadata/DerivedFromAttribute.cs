using System;

namespace BeneficialStrategies.Iso20022.Metadata;

/// <summary>
/// Specifies the adorned type is derived from the specified type.
/// </summary>
public class DerivedFromAttribute : System.Attribute
{
    /// <summary>
    /// Adorns an enum structure to specify the enum type that is being extended or restricted.
    /// </summary>
    /// <param name="derivedFromType"></param>
    public DerivedFromAttribute(Type derivedFromType)
    {
        DerivedFrom = derivedFromType;
    }

    /// <summary>
    /// The type the adorned type is derived from.
    /// </summary>
    public Type DerivedFrom { get; }
}
