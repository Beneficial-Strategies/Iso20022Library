// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of a amount (for loyalty or account).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ipaEINtlEeipuvJHTHIw9A")]
[Description(@"Unit of a amount (for loyalty or account).")]
[DerivedFrom(typeof(AmountUnitCode))]
public enum AmountUnit1Code
{
    /// <summary>
    /// The amount is expressed in a monetary value in a currency.
    /// Encoded/decoded by serializers as &quot;MONE&quot;.
    /// </summary>
    [EnumMember(Value = "MONE")]
    [IsoId("_lOTp0dtlEeipuvJHTHIw9A")]
    [Description(@"The amount is expressed in a monetary value in a currency.")]
    Monetary = AmountUnitCode.Monetary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The amount is expressed in point.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_lSlF0dtlEeipuvJHTHIw9A")]
    [Description(@"The amount is expressed in point.")]
    Point = AmountUnitCode.Point, // same ordinal as derivation source for type conversions
    
}
