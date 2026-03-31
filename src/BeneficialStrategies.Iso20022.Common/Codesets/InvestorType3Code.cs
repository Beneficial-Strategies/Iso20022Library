// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H58RoNdkEeibyvRfU9vJ7w")]
[Description(@"Specifies the type of investor.")]
[DerivedFrom(typeof(InvestorTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestorType3Code>))]
#endif
public enum InvestorType3Code
{
    /// <summary>
    /// Investor is a retail investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_KSbzAddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is a retail investor.")]
    Retail = InvestorTypeCode.Retail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is professional or professional per se.
    /// Encoded/decoded by serializers as &quot;PRF2&quot;.
    /// </summary>
    [EnumMember(Value = "PRF2")]
    [IsoId("_LvkfYddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is professional or professional per se.")]
    ProfessionalOrPerSe = InvestorTypeCode.ProfessionalOrPerSe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is neither professional or retail.
    /// Encoded/decoded by serializers as &quot;NEI1&quot;.
    /// </summary>
    [EnumMember(Value = "NEI1")]
    [IsoId("_Mq77cddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is neither professional or retail.")]
    NeitherProfessionalOrRetail = InvestorTypeCode.NeitherProfessionalOrRetail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor is both professional and retail.
    /// Encoded/decoded by serializers as &quot;BOT2&quot;.
    /// </summary>
    [EnumMember(Value = "BOT2")]
    [IsoId("_NgC-gddkEeibyvRfU9vJ7w")]
    [Description(@"Investor is both professional and retail.")]
    BothProfessionalAndRetail = InvestorTypeCode.BothProfessionalAndRetail, // same ordinal as derivation source for type conversions
}
