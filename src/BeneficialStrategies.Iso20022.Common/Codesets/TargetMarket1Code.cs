// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial product is in scope of a target market parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8M8twNddEeibyvRfU9vJ7w")]
[Description(@"Specifies whether a financial product is in scope of a target market parameter.")]
[DerivedFrom(typeof(TargetMarketCode))]
public enum TargetMarket1Code
{
    /// <summary>
    /// Yes, is applicable.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("_9woHAdddEeibyvRfU9vJ7w")]
    [Description(@"Yes, is applicable.")]
    InScope = TargetMarketCode.InScope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_936awdddEeibyvRfU9vJ7w")]
    [Description(@"Neutral or has no impact.")]
    Neutral = TargetMarketCode.Neutral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No, is not applicable.
    /// Encoded/decoded by serializers as &quot;NSCO&quot;.
    /// </summary>
    [EnumMember(Value = "NSCO")]
    [IsoId("_-SsSQdddEeibyvRfU9vJ7w")]
    [Description(@"No, is not applicable.")]
    NotInScope = TargetMarketCode.NotInScope, // same ordinal as derivation source for type conversions
    
}
