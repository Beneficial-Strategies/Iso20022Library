// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of discount, that is, the reason why a discount is granted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TQ3_sAEcEeCQm6a_G2yO_w_-1597992026")]
[Description(@"Specifies the type of discount, that is, the reason why a discount is granted.")]
[DerivedFrom(typeof(DiscountTypeCode))]
public enum DiscountType1Code
{
    /// <summary>
    /// Quantity discount.
    /// Encoded/decoded by serializers as &quot;QUAN&quot;.
    /// </summary>
    [EnumMember(Value = "QUAN")]
    [IsoId("_TQ3_sQEcEeCQm6a_G2yO_w_1171814968")]
    [Description(@"Quantity discount.")]
    QuantityDiscount = DiscountTypeCode.QuantityDiscount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Promotional discount.
    /// Encoded/decoded by serializers as &quot;PROM&quot;.
    /// </summary>
    [EnumMember(Value = "PROM")]
    [IsoId("_TQ3_sgEcEeCQm6a_G2yO_w_-1656003565")]
    [Description(@"Promotional discount.")]
    PromotionalDiscount = DiscountTypeCode.PromotionalDiscount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pricing discount.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_TQ3_swEcEeCQm6a_G2yO_w_1625902237")]
    [Description(@"Pricing discount.")]
    PricingDiscount = DiscountTypeCode.PricingDiscount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Special agreement discount.
    /// Encoded/decoded by serializers as &quot;SPAG&quot;.
    /// </summary>
    [EnumMember(Value = "SPAG")]
    [IsoId("_TQ3_tAEcEeCQm6a_G2yO_w_-1201916296")]
    [Description(@"Special agreement discount.")]
    SpecialAgreementDiscount = DiscountTypeCode.SpecialAgreementDiscount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End-of-range discount.
    /// Encoded/decoded by serializers as &quot;ENOR&quot;.
    /// </summary>
    [EnumMember(Value = "ENOR")]
    [IsoId("_TQ3_tQEcEeCQm6a_G2yO_w_1614803460")]
    [Description(@"End-of-range discount.")]
    EndOfRangeDiscount = DiscountTypeCode.EndOfRangeDiscount, // same ordinal as derivation source for type conversions
}
