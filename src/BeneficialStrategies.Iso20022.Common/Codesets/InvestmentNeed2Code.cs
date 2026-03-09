// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an investment need.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gKzBAKDtEequlaOyi6MUhw")]
[Description(@"Specifies an investment need.")]
[DerivedFrom(typeof(InvestmentNeedCode))]
public enum InvestmentNeed2Code
{
    /// <summary>
    /// No specific need.
    /// Encoded/decoded by serializers as &quot;NSPE&quot;.
    /// </summary>
    [EnumMember(Value = "NSPE")]
    [IsoId("_i8cCMaDtEequlaOyi6MUhw")]
    [Description(@"No specific need.")]
    None = InvestmentNeedCode.None, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other specific need.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jD4G8aDtEequlaOyi6MUhw")]
    [Description(@"Other specific need.")]
    Other = InvestmentNeedCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment need is for Islamic banking.
    /// Encoded/decoded by serializers as &quot;ISLB&quot;.
    /// </summary>
    [EnumMember(Value = "ISLB")]
    [IsoId("_jK3fwaDtEequlaOyi6MUhw")]
    [Description(@"Investment need is for Islamic banking.")]
    IslamicBanking = InvestmentNeedCode.IslamicBanking, // same ordinal as derivation source for type conversions
    
}
