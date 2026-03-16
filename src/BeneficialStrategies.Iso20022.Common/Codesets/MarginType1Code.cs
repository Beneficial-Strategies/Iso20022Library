// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-f_exKMOEeCojJW5vEuTEQ_-359654554")]
[Description(
    @"Indicates the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin."
)]
[DerivedFrom(typeof(MarginTypeCode))]
public enum MarginType1Code
{
    /// <summary>
    /// Margin required to cover the risk of non settlement of the underlying. Also used to cover the risk linked to the non settlement on payment platforms (for example TARGET2 vs CLS).
    /// Encoded/decoded by serializers as &quot;SEMA&quot;.
    /// </summary>
    [EnumMember(Value = "SEMA")]
    [IsoId("_-f_exaMOEeCojJW5vEuTEQ_-1108525466")]
    [Description(
        @"Margin required to cover the risk of non settlement of the underlying. Also used to cover the risk linked to the non settlement on payment platforms (for example TARGET2 vs CLS)."
    )]
    SettlementRiskMargin = MarginTypeCode.SettlementRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional margin required to cover the daily risk encountered by the central counterparty before the clearing member is actually called to cover the default fund. Indeed, central counterparty calculates the margin on the default fund on a daily basis but only calls the clearing member at the end of the month.
    /// Encoded/decoded by serializers as &quot;ADFM&quot;.
    /// </summary>
    [EnumMember(Value = "ADFM")]
    [IsoId("_-f_exqMOEeCojJW5vEuTEQ_858498413")]
    [Description(
        @"Additional margin required to cover the daily risk encountered by the central counterparty before the clearing member is actually called to cover the default fund. Indeed, central counterparty calculates the margin on the default fund on a daily basis but only calls the clearing member at the end of the month."
    )]
    AdditionalDefaultFundMargin = MarginTypeCode.AdditionalDefaultFundMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the concentration risk linked to the default of the seller of the &quot;protection&quot; (for example CDS seller).
    /// Encoded/decoded by serializers as &quot;SCMA&quot;.
    /// </summary>
    [EnumMember(Value = "SCMA")]
    [IsoId("_-f_ex6MOEeCojJW5vEuTEQ_-1969320120")]
    [Description(
        @"Margin required to cover the concentration risk linked to the default of the seller of the ""protection"" (for example CDS seller)."
    )]
    ShortChargeMargin = MarginTypeCode.ShortChargeMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the non payment of the monthly premium (for credit derivatives).
    /// Encoded/decoded by serializers as &quot;COMA&quot;.
    /// </summary>
    [EnumMember(Value = "COMA")]
    [IsoId("_-gJPwKMOEeCojJW5vEuTEQ_-74437305")]
    [Description(
        @"Margin required to cover the non payment of the monthly premium (for credit derivatives)."
    )]
    CouponMargin = MarginTypeCode.CouponMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the non payment of the upfront premium (for credit derivatives).
    /// Encoded/decoded by serializers as &quot;UFMA&quot;.
    /// </summary>
    [EnumMember(Value = "UFMA")]
    [IsoId("_-gJPwaMOEeCojJW5vEuTEQ_1392711458")]
    [Description(
        @"Margin required to cover the non payment of the upfront premium (for credit derivatives)."
    )]
    UpfrontMargin = MarginTypeCode.UpfrontMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the risk of any event linked to the underlying (for example the payment default by the issuer of a debt).
    /// Encoded/decoded by serializers as &quot;CEMA&quot;.
    /// </summary>
    [EnumMember(Value = "CEMA")]
    [IsoId("_-gJPwqMOEeCojJW5vEuTEQ_1003583033")]
    [Description(
        @"Margin required to cover the risk of any event linked to the underlying (for example the payment default by the issuer of a debt)."
    )]
    CreditEventMargin = MarginTypeCode.CreditEventMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to enable a member to start trading on a specific market where high risks and amounts are involved.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_-gJPw6MOEeCojJW5vEuTEQ_1764348186")]
    [Description(
        @"Margin required to enable a member to start trading on a specific market where high risks and amounts are involved."
    )]
    InitialDeposit = MarginTypeCode.InitialDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin calculated on the same basis as for the variation margin but the margin is kept by the central counterparty and not &quot;paid &quot; to the other clearing member.
    /// Encoded/decoded by serializers as &quot;NEMA&quot;.
    /// </summary>
    [EnumMember(Value = "NEMA")]
    [IsoId("_-gJPxKMOEeCojJW5vEuTEQ_-1063470347")]
    [Description(
        @"Margin calculated on the same basis as for the variation margin but the margin is kept by the central counterparty and not ""paid "" to the other clearing member."
    )]
    NegociationMargin = MarginTypeCode.NegociationMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.
    /// Encoded/decoded by serializers as &quot;INMA&quot;.
    /// </summary>
    [EnumMember(Value = "INMA")]
    [IsoId("_-gJPxaMOEeCojJW5vEuTEQ_-2045355572")]
    [Description(
        @"Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty."
    )]
    InitialMargin = MarginTypeCode.InitialMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the risk linked to the price fluctuations occurred on the unsettled exposures towards central counterparty.
    /// Encoded/decoded by serializers as &quot;VAMA&quot;.
    /// </summary>
    [EnumMember(Value = "VAMA")]
    [IsoId("_-gJPxqMOEeCojJW5vEuTEQ_40165298")]
    [Description(
        @"Margin required to cover the risk linked to the price fluctuations occurred on the unsettled exposures towards central counterparty."
    )]
    VariationMargin = MarginTypeCode.VariationMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional margin required to cover a risk increase (expressed in the reporting currency). This results from a risk management decision depending on central counterparty specific criteria.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_-gJPx6MOEeCojJW5vEuTEQ_1557992201")]
    [Description(
        @"Additional margin required to cover a risk increase (expressed in the reporting currency). This results from a risk management decision depending on central counterparty specific criteria."
    )]
    IncreaseCoverageAmount = MarginTypeCode.IncreaseCoverageAmount, // same ordinal as derivation source for type conversions
}
