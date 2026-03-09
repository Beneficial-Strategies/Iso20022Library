// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-fsj2qMOEeCojJW5vEuTEQ_-1682565649")]
[Description(@"Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.")]
[Derivations(typeof(MarginType1Code),typeof(MarginType2Code))]
public enum MarginTypeCode
{
    /// <summary>
    /// Margin required to cover the risk of non settlement of the underlying. Also used to cover the risk linked to the non settlement on payment platforms (for example TARGET2 vs CLS).
    /// Encoded/decoded by serializers as &quot;SEMA&quot;.
    /// </summary>
    [EnumMember(Value = "SEMA")]
    [IsoId("_-f1twKMOEeCojJW5vEuTEQ_-2034787711")]
    [Description(@"Margin required to cover the risk of non settlement of the underlying. Also used to cover the risk linked to the non settlement on payment platforms (for example TARGET2 vs CLS).")]
    SettlementRiskMargin,
    
    /// <summary>
    /// Additional margin required to cover the daily risk encountered by the central counterparty before the clearing member is actually called to cover the default fund. Indeed, central counterparty calculates the margin on the default fund on a daily basis but only calls the clearing member at the end of the month.
    /// Encoded/decoded by serializers as &quot;ADFM&quot;.
    /// </summary>
    [EnumMember(Value = "ADFM")]
    [IsoId("_-f1twaMOEeCojJW5vEuTEQ_-1116360912")]
    [Description(@"Additional margin required to cover the daily risk encountered by the central counterparty before the clearing member is actually called to cover the default fund. Indeed, central counterparty calculates the margin on the default fund on a daily basis but only calls the clearing member at the end of the month.")]
    AdditionalDefaultFundMargin,
    
    /// <summary>
    /// Margin required to cover the concentration risk linked to the default of the seller of the &quot;protection&quot; (for example CDS seller).
    /// Encoded/decoded by serializers as &quot;SCMA&quot;.
    /// </summary>
    [EnumMember(Value = "SCMA")]
    [IsoId("_-f1twqMOEeCojJW5vEuTEQ_-1044911117")]
    [Description(@"Margin required to cover the concentration risk linked to the default of the seller of the ""protection"" (for example CDS seller).")]
    ShortChargeMargin,
    
    /// <summary>
    /// Margin required to cover the non payment of the monthly premium (for credit derivatives).
    /// Encoded/decoded by serializers as &quot;COMA&quot;.
    /// </summary>
    [EnumMember(Value = "COMA")]
    [IsoId("_-f1tw6MOEeCojJW5vEuTEQ_532812294")]
    [Description(@"Margin required to cover the non payment of the monthly premium (for credit derivatives).")]
    CouponMargin,
    
    /// <summary>
    /// Margin required to cover the non payment of the upfront premium (for credit derivatives).
    /// Encoded/decoded by serializers as &quot;UFMA&quot;.
    /// </summary>
    [EnumMember(Value = "UFMA")]
    [IsoId("_-f1txKMOEeCojJW5vEuTEQ_1129854074")]
    [Description(@"Margin required to cover the non payment of the upfront premium (for credit derivatives).")]
    UpfrontMargin,
    
    /// <summary>
    /// Margin required to cover the risk of any event linked to the underlying (for example the payment default by the issuer of a debt).
    /// Encoded/decoded by serializers as &quot;CEMA&quot;.
    /// </summary>
    [EnumMember(Value = "CEMA")]
    [IsoId("_-f1txaMOEeCojJW5vEuTEQ_-978337171")]
    [Description(@"Margin required to cover the risk of any event linked to the underlying (for example the payment default by the issuer of a debt).")]
    CreditEventMargin,
    
    /// <summary>
    /// Margin required to enable a member to start trading on a specific market where high risks and amounts are involved.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_-f1txqMOEeCojJW5vEuTEQ_-1078255203")]
    [Description(@"Margin required to enable a member to start trading on a specific market where high risks and amounts are involved.")]
    InitialDeposit,
    
    /// <summary>
    /// Margin calculated on the same basis as for the variation margin but the margin is kept by the central counterparty and not &quot;paid &quot; to the other clearing member.
    /// Encoded/decoded by serializers as &quot;NEMA&quot;.
    /// </summary>
    [EnumMember(Value = "NEMA")]
    [IsoId("_-f_ewKMOEeCojJW5vEuTEQ_1562428186")]
    [Description(@"Margin calculated on the same basis as for the variation margin but the margin is kept by the central counterparty and not ""paid "" to the other clearing member.")]
    NegociationMargin,
    
    /// <summary>
    /// Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.
    /// Encoded/decoded by serializers as &quot;INMA&quot;.
    /// </summary>
    [EnumMember(Value = "INMA")]
    [IsoId("_-f_ewaMOEeCojJW5vEuTEQ_-1434830201")]
    [Description(@"Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.")]
    InitialMargin,
    
    /// <summary>
    /// Margin required to cover the risk linked to the price fluctuations occurred on the unsettled exposures towards central counterparty.
    /// Encoded/decoded by serializers as &quot;VAMA&quot;.
    /// </summary>
    [EnumMember(Value = "VAMA")]
    [IsoId("_-f_ewqMOEeCojJW5vEuTEQ_-313675587")]
    [Description(@"Margin required to cover the risk linked to the price fluctuations occurred on the unsettled exposures towards central counterparty.")]
    VariationMargin,
    
    /// <summary>
    /// Additional margin required to cover a risk increase (expressed in the reporting currency). This results from a risk management decision depending on central counterparty specific criteria.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_-f_ew6MOEeCojJW5vEuTEQ_320898032")]
    [Description(@"Additional margin required to cover a risk increase (expressed in the reporting currency). This results from a risk management decision depending on central counterparty specific criteria.")]
    IncreaseCoverageAmount,
    
    /// <summary>
    /// Margin called to cover differences in the assumed liquidation cost of a portfolio of financial instruments when estimating potential future exposure relative. For instance, where the potential future exposure is estimated using mid-prices but fails to consider the necessity to pay a bid-ask spread, or the additional cost of liquidation that may arise when liquidating a large portfolio.
    /// Encoded/decoded by serializers as &quot;LIRM&quot;.
    /// </summary>
    [EnumMember(Value = "LIRM")]
    [IsoId("_RGhM8KsjEeayv9XxdmMwKQ")]
    [Description(@"Margin called to cover differences in the assumed liquidation cost of a portfolio of financial instruments when estimating potential future exposure relative. For instance, where the potential future exposure is estimated using mid-prices but fails to consider the necessity to pay a bid-ask spread, or the additional cost of liquidation that may arise when liquidating a large portfolio.")]
    LiquidityRiskMargin,
    
    /// <summary>
    /// Margin requirement to cover the risk of a breakdown in the assumed relationship between two financial instruments or risk factors when calculating the margin requirement for a portfolio of financial instruments.
    /// Encoded/decoded by serializers as &quot;BARM&quot;.
    /// </summary>
    [EnumMember(Value = "BARM")]
    [IsoId("_Xtoq4KsjEeayv9XxdmMwKQ")]
    [Description(@"Margin requirement to cover the risk of a breakdown in the assumed relationship between two financial instruments or risk factors when calculating the margin requirement for a portfolio of financial instruments.")]
    BasisRiskMargin,
    
    /// <summary>
    /// Margin called to cover additional current or potential future exposures that may arise due to a connection between the credit quality of the counterparty and the movement in a set of risk factors of a financial instruments or portfolio of financial instruments.
    /// Encoded/decoded by serializers as &quot;WWRM&quot;.
    /// </summary>
    [EnumMember(Value = "WWRM")]
    [IsoId("_dZO7wKsjEeayv9XxdmMwKQ")]
    [Description(@"Margin called to cover additional current or potential future exposures that may arise due to a connection between the credit quality of the counterparty and the movement in a set of risk factors of a financial instruments or portfolio of financial instruments.")]
    WrongWayRiskMargin,
    
    /// <summary>
    /// Margin to cover the risk of a credit event relating to a sovereign issuer.
    /// Encoded/decoded by serializers as &quot;SORM&quot;.
    /// </summary>
    [EnumMember(Value = "SORM")]
    [IsoId("_g3DtgKsjEeayv9XxdmMwKQ")]
    [Description(@"Margin to cover the risk of a credit event relating to a sovereign issuer.")]
    SovereignRiskMargin,
    
    /// <summary>
    /// Margin called to cover potential future exposures caused by volatility in the underlying risk factors of a set of financial instruments.
    /// Encoded/decoded by serializers as &quot;MARM&quot;.
    /// </summary>
    [EnumMember(Value = "MARM")]
    [IsoId("_oE_64KsjEeayv9XxdmMwKQ")]
    [Description(@"Margin called to cover potential future exposures caused by volatility in the underlying risk factors of a set of financial instruments.")]
    MarketRiskMargin,
    
    /// <summary>
    /// Margin called to cover an increase in the probability of default by a counterparty in relation to an OTC derivative or cleared transaction. The calculation of such margin is typically independent of any changes in current or potential future exposure.
    /// Encoded/decoded by serializers as &quot;CRAM&quot;.
    /// </summary>
    [EnumMember(Value = "CRAM")]
    [IsoId("_PGoXoK16EeaJ-ZG7I88yBQ")]
    [Description(@"Margin called to cover an increase in the probability of default by a counterparty in relation to an OTC derivative or cleared transaction. The calculation of such margin is typically independent of any changes in current or potential future exposure.")]
    CreditRiskAdditionalMargin,
    
    /// <summary>
    /// Margin called, by a central counterparty, to cover current exposures for a portfolio of financial instruments where collateral called against such current exposures is held by the central counterparty and returned to the poster of such collateral at the delivery of the financial instrument.
    /// Encoded/decoded by serializers as &quot;CVMA&quot;.
    /// </summary>
    [EnumMember(Value = "CVMA")]
    [IsoId("_hp1i4PqDEeaQh_7a05rSJQ")]
    [Description(@"Margin called, by a central counterparty, to cover current exposures for a portfolio of financial instruments where collateral called against such current exposures is held by the central counterparty and returned to the poster of such collateral at the delivery of the financial instrument.")]
    ContingentVariationMargin,
    
    /// <summary>
    /// Margin to cover risks relating to a sponsored clearing member. That is were a third party carries out a number of obligations under the rulebook of the central counterparty on behalf of a clearing member but doing so creates additional risks for the central counterparty with respect to the clearing member.
    /// Encoded/decoded by serializers as &quot;SPMA&quot;.
    /// </summary>
    [EnumMember(Value = "SPMA")]
    [IsoId("_mvzXIPqDEeaQh_7a05rSJQ")]
    [Description(@"Margin to cover risks relating to a sponsored clearing member. That is were a third party carries out a number of obligations under the rulebook of the central counterparty on behalf of a clearing member but doing so creates additional risks for the central counterparty with respect to the clearing member.")]
    SponsorRiskMargin,
    
    /// <summary>
    /// Margin called to cover a potential increase in current exposure due to the revaluation of a financial instrument, where such revaluation is caused by a sharp discontinuous increase in the probability of default of the financial instrument or major risk factor of such financial instrument.
    /// Encoded/decoded by serializers as &quot;JTDR&quot;.
    /// </summary>
    [EnumMember(Value = "JTDR")]
    [IsoId("_sRvVsPqDEeaQh_7a05rSJQ")]
    [Description(@"Margin called to cover a potential increase in current exposure due to the revaluation of a financial instrument, where such revaluation is caused by a sharp discontinuous increase in the probability of default of the financial instrument or major risk factor of such financial instrument.")]
    JumpToDefaultRequirement,
    
    /// <summary>
    /// Margin set called at the discretion of the caller.
    /// Encoded/decoded by serializers as &quot;DRAO&quot;.
    /// </summary>
    [EnumMember(Value = "DRAO")]
    [IsoId("_yjbWMPqDEeaQh_7a05rSJQ")]
    [Description(@"Margin set called at the discretion of the caller.")]
    DiscretionaryRiskAddOn,
    
    /// <summary>
    /// Margin not categorised by any other margin type code.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_4STkkPqDEeaQh_7a05rSJQ")]
    [Description(@"Margin not categorised by any other margin type code.")]
    Other,
    
}
