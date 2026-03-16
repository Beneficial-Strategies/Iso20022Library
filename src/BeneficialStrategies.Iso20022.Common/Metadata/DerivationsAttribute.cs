using System;

namespace BeneficialStrategies.Iso20022.Metadata;

/// <summary>
/// Specifies the types that are derived as extensions or restrictions of this type.
/// </summary>
public class DerivationsAttribute : System.Attribute
{
    /// <summary>
    /// Specifies the types that are derived as extensions or restrictions of this type.
    /// </summary>
    /// <param name="derivedTypes">One or more types that are derived from this type.</param>
    public DerivationsAttribute(params Type[] derivedTypes)
    {
        DerivedTypes = derivedTypes;
    }

    /// <summary>
    /// The types that are derived as extensions or restrictions of this type.
    /// </summary>
    public Type[] DerivedTypes { get; }
}
