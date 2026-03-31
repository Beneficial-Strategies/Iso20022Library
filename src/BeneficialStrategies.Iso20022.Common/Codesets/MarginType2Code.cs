// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7TLccKsiEeayv9XxdmMwKQ")]
[Description(
    @"Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin."
)]
[DerivedFrom(typeof(MarginTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarginType2Code>))]
#endif
public enum MarginType2Code
{
    /// <summary>
    /// Additional margin required to cover the daily risk encountered by the central counterparty before the clearing member is actually called to cover the default fund. Indeed, central counterparty calculates the margin on the default fund on a daily basis but only calls the clearing member at the end of the month.
    /// Encoded/decoded by serializers as &quot;ADFM&quot;.
    /// </summary>
    [EnumMember(Value = "ADFM")]
    [IsoId("_946IkasiEeayv9XxdmMwKQ")]
    [Description(
        @"Additional margin required to cover the daily risk encountered by the central counterparty before the clearing member is actually called to cover the default fund. Indeed, central counterparty calculates the margin on the default fund on a daily basis but only calls the clearing member at the end of the month."
    )]
    AdditionalDefaultFundMargin = MarginTypeCode.AdditionalDefaultFundMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the non payment of the monthly premium (for credit derivatives).
    /// Encoded/decoded by serializers as &quot;COMA&quot;.
    /// </summary>
    [EnumMember(Value = "COMA")]
    [IsoId("_Ba5ooasjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin required to cover the non payment of the monthly premium (for credit derivatives)."
    )]
    CouponMargin = MarginTypeCode.CouponMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the risk of any event linked to the underlying (for example the payment default by the issuer of a debt).
    /// Encoded/decoded by serializers as &quot;CEMA&quot;.
    /// </summary>
    [EnumMember(Value = "CEMA")]
    [IsoId("_DZD-casjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin required to cover the risk of any event linked to the underlying (for example the payment default by the issuer of a debt)."
    )]
    CreditEventMargin = MarginTypeCode.CreditEventMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the risk of non settlement of the underlying. Also used to cover the risk linked to the non settlement on payment platforms (for example TARGET2 vs CLS).
    /// Encoded/decoded by serializers as &quot;SEMA&quot;.
    /// </summary>
    [EnumMember(Value = "SEMA")]
    [IsoId("_Km2a0asjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin required to cover the risk of non settlement of the underlying. Also used to cover the risk linked to the non settlement on payment platforms (for example TARGET2 vs CLS)."
    )]
    SettlementRiskMargin = MarginTypeCode.SettlementRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the concentration risk linked to the default of the seller of the &quot;protection&quot; (for example CDS seller).
    /// Encoded/decoded by serializers as &quot;SCMA&quot;.
    /// </summary>
    [EnumMember(Value = "SCMA")]
    [IsoId("_MTm3kasjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin required to cover the concentration risk linked to the default of the seller of the ""protection"" (for example CDS seller)."
    )]
    ShortChargeMargin = MarginTypeCode.ShortChargeMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin required to cover the non payment of the upfront premium (for credit derivatives).
    /// Encoded/decoded by serializers as &quot;UFMA&quot;.
    /// </summary>
    [EnumMember(Value = "UFMA")]
    [IsoId("_NRWSMasjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin required to cover the non payment of the upfront premium (for credit derivatives)."
    )]
    UpfrontMargin = MarginTypeCode.UpfrontMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin called to cover potential future exposures caused by volatility in the underlying risk factors of a set of financial instruments.
    /// Encoded/decoded by serializers as &quot;MARM&quot;.
    /// </summary>
    [EnumMember(Value = "MARM")]
    [IsoId("_uHELAasjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin called to cover potential future exposures caused by volatility in the underlying risk factors of a set of financial instruments."
    )]
    MarketRiskMargin = MarginTypeCode.MarketRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin to cover the risk of a credit event relating to a sovereign issuer.
    /// Encoded/decoded by serializers as &quot;SORM&quot;.
    /// </summary>
    [EnumMember(Value = "SORM")]
    [IsoId("_uP_dgasjEeayv9XxdmMwKQ")]
    [Description(@"Margin to cover the risk of a credit event relating to a sovereign issuer.")]
    SovereignRiskMargin = MarginTypeCode.SovereignRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin called to cover additional current or potential future exposures that may arise due to a connection between the credit quality of the counterparty and the movement in a set of risk factors of a financial instruments or portfolio of financial instruments.
    /// Encoded/decoded by serializers as &quot;WWRM&quot;.
    /// </summary>
    [EnumMember(Value = "WWRM")]
    [IsoId("_ucV3casjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin called to cover additional current or potential future exposures that may arise due to a connection between the credit quality of the counterparty and the movement in a set of risk factors of a financial instruments or portfolio of financial instruments."
    )]
    WrongWayRiskMargin = MarginTypeCode.WrongWayRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin requirement to cover the risk of a breakdown in the assumed relationship between two financial instruments or risk factors when calculating the margin requirement for a portfolio of financial instruments.
    /// Encoded/decoded by serializers as &quot;BARM&quot;.
    /// </summary>
    [EnumMember(Value = "BARM")]
    [IsoId("_urXK4asjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin requirement to cover the risk of a breakdown in the assumed relationship between two financial instruments or risk factors when calculating the margin requirement for a portfolio of financial instruments."
    )]
    BasisRiskMargin = MarginTypeCode.BasisRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin called to cover differences in the assumed liquidation cost of a portfolio of financial instruments when estimating potential future exposure relative. For instance, where the potential future exposure is estimated using mid-prices but fails to consider the necessity to pay a bid-ask spread, or the additional cost of liquidation that may arise when liquidating a large portfolio.
    /// Encoded/decoded by serializers as &quot;LIRM&quot;.
    /// </summary>
    [EnumMember(Value = "LIRM")]
    [IsoId("_u2OXEasjEeayv9XxdmMwKQ")]
    [Description(
        @"Margin called to cover differences in the assumed liquidation cost of a portfolio of financial instruments when estimating potential future exposure relative. For instance, where the potential future exposure is estimated using mid-prices but fails to consider the necessity to pay a bid-ask spread, or the additional cost of liquidation that may arise when liquidating a large portfolio."
    )]
    LiquidityRiskMargin = MarginTypeCode.LiquidityRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin called to cover an increase in the probability of default by a counterparty in relation to an OTC derivative or cleared transaction. The calculation of such margin is typically independent of any changes in current or potential future exposure.
    /// Encoded/decoded by serializers as &quot;CRAM&quot;.
    /// </summary>
    [EnumMember(Value = "CRAM")]
    [IsoId("_f0mw0a16EeaJ-ZG7I88yBQ")]
    [Description(
        @"Margin called to cover an increase in the probability of default by a counterparty in relation to an OTC derivative or cleared transaction. The calculation of such margin is typically independent of any changes in current or potential future exposure."
    )]
    CreditRiskAdditionalMargin = MarginTypeCode.CreditRiskAdditionalMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin called, by a central counterparty, to cover current exposures for a portfolio of financial instruments where collateral called against such current exposures is held by the central counterparty and returned to the poster of such collateral at the delivery of the financial instrument.
    /// Encoded/decoded by serializers as &quot;CVMA&quot;.
    /// </summary>
    [EnumMember(Value = "CVMA")]
    [IsoId("_-bz5cfqDEeaQh_7a05rSJQ")]
    [Description(
        @"Margin called, by a central counterparty, to cover current exposures for a portfolio of financial instruments where collateral called against such current exposures is held by the central counterparty and returned to the poster of such collateral at the delivery of the financial instrument."
    )]
    ContingentVariationMargin = MarginTypeCode.ContingentVariationMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin to cover risks relating to a sponsored clearing member. That is were a third party carries out a number of obligations under the rulebook of the central counterparty on behalf of a clearing member but doing so creates additional risks for the central counterparty with respect to the clearing member.
    /// Encoded/decoded by serializers as &quot;SPMA&quot;.
    /// </summary>
    [EnumMember(Value = "SPMA")]
    [IsoId("__aAAAfqDEeaQh_7a05rSJQ")]
    [Description(
        @"Margin to cover risks relating to a sponsored clearing member. That is were a third party carries out a number of obligations under the rulebook of the central counterparty on behalf of a clearing member but doing so creates additional risks for the central counterparty with respect to the clearing member."
    )]
    SponsorRiskMargin = MarginTypeCode.SponsorRiskMargin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin called to cover a potential increase in current exposure due to the revaluation of a financial instrument, where such revaluation is caused by a sharp discontinuous increase in the probability of default of the financial instrument or major risk factor of such financial instrument.
    /// Encoded/decoded by serializers as &quot;JTDR&quot;.
    /// </summary>
    [EnumMember(Value = "JTDR")]
    [IsoId("_AK8UwfqEEeaQh_7a05rSJQ")]
    [Description(
        @"Margin called to cover a potential increase in current exposure due to the revaluation of a financial instrument, where such revaluation is caused by a sharp discontinuous increase in the probability of default of the financial instrument or major risk factor of such financial instrument."
    )]
    JumpToDefaultRequirement = MarginTypeCode.JumpToDefaultRequirement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin set called at the discretion of the caller.
    /// Encoded/decoded by serializers as &quot;DRAO&quot;.
    /// </summary>
    [EnumMember(Value = "DRAO")]
    [IsoId("_BQ3bAfqEEeaQh_7a05rSJQ")]
    [Description(@"Margin set called at the discretion of the caller.")]
    DiscretionaryRiskAddOn = MarginTypeCode.DiscretionaryRiskAddOn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin not categorised by any other margin type code.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_BuB4IfqEEeaQh_7a05rSJQ")]
    [Description(@"Margin not categorised by any other margin type code.")]
    Other = MarginTypeCode.Other, // same ordinal as derivation source for type conversions
}
