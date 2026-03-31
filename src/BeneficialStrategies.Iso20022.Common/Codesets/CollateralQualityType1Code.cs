// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Risk classification of the security used as collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_x0bGkMkVEeeiAIB1i4AlQw")]
[Description(@"Risk classification of the security used as collateral.")]
[DerivedFrom(typeof(CollateralQualityTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralQualityType1Code>))]
#endif
public enum CollateralQualityType1Code
{
    /// <summary>
    /// Security that is classified as investment grade according to external ratings.
    /// Encoded/decoded by serializers as &quot;INVG&quot;.
    /// </summary>
    [EnumMember(Value = "INVG")]
    [IsoId("_zUP6kckVEeeiAIB1i4AlQw")]
    [Description(@"Security that is classified as investment grade according to external ratings.")]
    InvestmentGrade = CollateralQualityTypeCode.InvestmentGrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security with a rating different than investment grade.
    /// Encoded/decoded by serializers as &quot;NIVG&quot;.
    /// </summary>
    [EnumMember(Value = "NIVG")]
    [IsoId("_zeO9AckVEeeiAIB1i4AlQw")]
    [Description(@"Security with a rating different than investment grade.")]
    NonInvestmentGrade = CollateralQualityTypeCode.NonInvestmentGrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security without a rating assigned.
    /// Encoded/decoded by serializers as &quot;NOTR&quot;.
    /// </summary>
    [EnumMember(Value = "NOTR")]
    [IsoId("_zkWMEckVEeeiAIB1i4AlQw")]
    [Description(@"Security without a rating assigned.")]
    NotRated = CollateralQualityTypeCode.NotRated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral quality type is not applicable.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_xAID4dQuEee86YlULvwLbQ")]
    [Description(@"Collateral quality type is not applicable.")]
    NonApplicable = CollateralQualityTypeCode.NonApplicable, // same ordinal as derivation source for type conversions
}
