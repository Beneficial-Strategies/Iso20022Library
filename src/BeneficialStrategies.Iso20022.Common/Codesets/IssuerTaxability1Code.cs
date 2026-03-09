// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the corporate action proceeds are taxable at issuer level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AwDc8PovEeCfbIXrKCjG0g")]
[Description(@"Specifies whether the corporate action proceeds are taxable at issuer level.")]
[DerivedFrom(typeof(IssuerTaxabilityCode))]
public enum IssuerTaxability1Code
{
    /// <summary>
    /// The cash proceeds are taxable.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_zlMDJgFKEeGOtY_0fwodfg")]
    [Description(@"The cash proceeds are taxable.")]
    Taxable = IssuerTaxabilityCode.Taxable, // same ordinal as derivation source for type conversions
    
}
