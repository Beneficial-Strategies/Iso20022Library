// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a financial product is in scope of a target market parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hXsYANdcEeibyvRfU9vJ7w")]
[Description(@"Specifies whether a financial product is in scope of a target market parameter.")]
[Derivations(typeof(TargetMarket1Code),typeof(TargetMarket2Code),typeof(TargetMarket3Code))]
public enum TargetMarketCode
{
    /// <summary>
    /// No, is not applicable.
    /// Encoded/decoded by serializers as &quot;NSCO&quot;.
    /// </summary>
    [EnumMember(Value = "NSCO")]
    [IsoId("_wXbtwNdcEeibyvRfU9vJ7w")]
    [Description(@"No, is not applicable.")]
    NotInScope,
    
    /// <summary>
    /// Yes, is applicable.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("_1WaJMNdcEeibyvRfU9vJ7w")]
    [Description(@"Yes, is applicable.")]
    InScope,
    
    /// <summary>
    /// Neutral or has no impact.
    /// Encoded/decoded by serializers as &quot;NEUT&quot;.
    /// </summary>
    [EnumMember(Value = "NEUT")]
    [IsoId("_4Qq64NdcEeibyvRfU9vJ7w")]
    [Description(@"Neutral or has no impact.")]
    Neutral,
    
    /// <summary>
    /// Not known whether applicable.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_-6d5YNdcEeibyvRfU9vJ7w")]
    [Description(@"Not known whether applicable.")]
    Unknown,
    
}
