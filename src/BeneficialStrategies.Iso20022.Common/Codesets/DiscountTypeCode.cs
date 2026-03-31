// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of discount, that is, the reason why a discount is granted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TQ3_tgEcEeCQm6a_G2yO_w_1270296506")]
[Description(@"Specifies the type of discount, that is, the reason why a discount is granted.")]
[Derivations(typeof(DiscountType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DiscountTypeCode>))]
#endif
public enum DiscountTypeCode
{
    /// <summary>
    /// Quantity discount.
    /// Encoded/decoded by serializers as &quot;QUAN&quot;.
    /// </summary>
    [EnumMember(Value = "QUAN")]
    [IsoId("_TQ3_twEcEeCQm6a_G2yO_w_-1191559935")]
    [Description(@"Quantity discount.")]
    QuantityDiscount,

    /// <summary>
    /// Promotional discount.
    /// Encoded/decoded by serializers as &quot;PROM&quot;.
    /// </summary>
    [EnumMember(Value = "PROM")]
    [IsoId("_TRd1kAEcEeCQm6a_G2yO_w_-1260131804")]
    [Description(@"Promotional discount.")]
    PromotionalDiscount,

    /// <summary>
    /// Pricing discount.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_TRd1kQEcEeCQm6a_G2yO_w_-215219395")]
    [Description(@"Pricing discount.")]
    PricingDiscount,

    /// <summary>
    /// Special agreement discount.
    /// Encoded/decoded by serializers as &quot;SPAG&quot;.
    /// </summary>
    [EnumMember(Value = "SPAG")]
    [IsoId("_TRd1kgEcEeCQm6a_G2yO_w_2120609041")]
    [Description(@"Special agreement discount.")]
    SpecialAgreementDiscount,

    /// <summary>
    /// End-of-range discount.
    /// Encoded/decoded by serializers as &quot;ENOR&quot;.
    /// </summary>
    [EnumMember(Value = "ENOR")]
    [IsoId("_TRd1kwEcEeCQm6a_G2yO_w_-36707206")]
    [Description(@"End-of-range discount.")]
    EndOfRangeDiscount,

    /// <summary>
    /// Addition discount based on third-party agreed business promotional activity, i.e., extra 10 percent discount for 15 days).
    /// Encoded/decoded by serializers as &quot;ADPS&quot;.
    /// </summary>
    [EnumMember(Value = "ADPS")]
    [IsoId("_Snf1wBRJEeKd9pI2QZcqvg_1802180027")]
    [Description(
        @"Addition discount based on third-party agreed business promotional activity, i.e., extra 10 percent discount for 15 days)."
    )]
    AdditionalPromotionalDiscount,

    /// <summary>
    /// Discount based on volume purchased.
    /// Encoded/decoded by serializers as &quot;STDS&quot;.
    /// </summary>
    [EnumMember(Value = "STDS")]
    [IsoId("_SqopUBRJEeKd9pI2QZcqvg_608728200")]
    [Description(@"Discount based on volume purchased.")]
    StandingDiscount,

    /// <summary>
    /// Discount based on terms negotiated for payment within a specified time period, i.e., 2/10 Net 30 (2 percent discount if paid in 10 days; otherwise, net amount is due in 30 days).
    /// Encoded/decoded by serializers as &quot;TMDS&quot;.
    /// </summary>
    [EnumMember(Value = "TMDS")]
    [IsoId("_SqxzQBRJEeKd9pI2QZcqvg_1045823300")]
    [Description(
        @"Discount based on terms negotiated for payment within a specified time period, i.e., 2/10 Net 30 (2 percent discount if paid in 10 days; otherwise, net amount is due in 30 days)."
    )]
    TermsDiscount,
}
