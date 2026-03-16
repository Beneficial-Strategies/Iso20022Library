// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SN44AMMSEee-Vv_OVx0uAQ")]
[Description(@"DTC Unallocated reason codes for payment adjustments.")]
[DerivedFrom(typeof(DTCUnallocatedAdjustmentReasonV2Code))]
public enum DTCUnallocatedAdjustmentReason4Code
{
    /// <summary>
    /// Issues funded and/or identified after the cycle cut off.
    /// Encoded/decoded by serializers as &quot;LFID&quot;.
    /// </summary>
    [EnumMember(Value = "LFID")]
    [IsoId("_7nigwcMSEee-Vv_OVx0uAQ")]
    [Description(@"Issues funded and/or identified after the cycle cut off.")]
    AfterCycleCutOff = DTCUnallocatedAdjustmentReasonV2Code.AfterCycleCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate is not final. Rate is approximate.
    /// Encoded/decoded by serializers as &quot;APRR&quot;.
    /// </summary>
    [EnumMember(Value = "APRR")]
    [IsoId("_7tWN0cMSEee-Vv_OVx0uAQ")]
    [Description(@"Rate is not final. Rate is approximate.")]
    ApproximateRate = DTCUnallocatedAdjustmentReasonV2Code.ApproximateRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect announcement.
    /// Encoded/decoded by serializers as &quot;ANNG&quot;.
    /// </summary>
    [EnumMember(Value = "ANNG")]
    [IsoId("_7ysn4cMSEee-Vv_OVx0uAQ")]
    [Description(@"Incorrect announcement.")]
    BadAnnouncement = DTCUnallocatedAdjustmentReasonV2Code.BadAnnouncement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect payable date.
    /// Encoded/decoded by serializers as &quot;BDPD&quot;.
    /// </summary>
    [EnumMember(Value = "BDPD")]
    [IsoId("_74DpAcMSEee-Vv_OVx0uAQ")]
    [Description(@"Incorrect payable date.")]
    BadPayableDate = DTCUnallocatedAdjustmentReasonV2Code.BadPayableDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to a call rescinded.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_75_iscMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a call rescinded.")]
    CallRescinded = DTCUnallocatedAdjustmentReasonV2Code.CallRescinded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to a Canadian depository inventory.
    /// Encoded/decoded by serializers as &quot;CDIN&quot;.
    /// </summary>
    [EnumMember(Value = "CDIN")]
    [IsoId("_7-wG4cMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a Canadian depository inventory.")]
    CanadianDepositoryInventory = DTCUnallocatedAdjustmentReasonV2Code.CanadianDepositoryInventory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHR&quot;.
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_8DzmAcMSEee-Vv_OVx0uAQ")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateUnknown = DTCUnallocatedAdjustmentReasonV2Code.CashRateUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to a CD accelerated maturity.
    /// Encoded/decoded by serializers as &quot;ERLY&quot;.
    /// </summary>
    [EnumMember(Value = "ERLY")]
    [IsoId("_8L2HscMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a CD accelerated maturity.")]
    CDAcceleratedMaturity = DTCUnallocatedAdjustmentReasonV2Code.CDAcceleratedMaturity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is conditional and conditions have not been met yet.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_8NefYcMSEee-Vv_OVx0uAQ")]
    [Description(@"Payment is conditional and conditions have not been met yet.")]
    ConditionalPayment = DTCUnallocatedAdjustmentReasonV2Code.ConditionalPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issue is in default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_8PHeIcMSEee-Vv_OVx0uAQ")]
    [Description(@"Issue is in default.")]
    Default = DTCUnallocatedAdjustmentReasonV2Code.Default, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to a five day grace period.
    /// Encoded/decoded by serializers as &quot;FVDG&quot;.
    /// </summary>
    [EnumMember(Value = "FVDG")]
    [IsoId("_8akgMcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a five day grace period.")]
    FiveDayGracePeriod = DTCUnallocatedAdjustmentReasonV2Code.FiveDayGracePeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds were not received by the agent.
    /// Encoded/decoded by serializers as &quot;ANFI&quot;.
    /// </summary>
    [EnumMember(Value = "ANFI")]
    [IsoId("_8cNe8cMSEee-Vv_OVx0uAQ")]
    [Description(@"Funds were not received by the agent.")]
    FundsNotReceivedByAgent = DTCUnallocatedAdjustmentReasonV2Code.FundsNotReceivedByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Company is taking a 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_8d12ocMSEee-Vv_OVx0uAQ")]
    [Description(@"Company is taking a 30 day grace period.")]
    GracePeriod = DTCUnallocatedAdjustmentReasonV2Code.GracePeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to holiday in country of origin.
    /// Encoded/decoded by serializers as &quot;HICO&quot;.
    /// </summary>
    [EnumMember(Value = "HICO")]
    [IsoId("_8i580cMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to holiday in country of origin.")]
    HolidayInCountryOfOrigin = DTCUnallocatedAdjustmentReasonV2Code.HolidayInCountryOfOrigin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to issue that was not funded.
    /// Encoded/decoded by serializers as &quot;ISNF&quot;.
    /// </summary>
    [EnumMember(Value = "ISNF")]
    [IsoId("_8uW-4cMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to issue that was not funded.")]
    IssueNotFunded = DTCUnallocatedAdjustmentReasonV2Code.IssueNotFunded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to issue that is not maturing.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_8wJHkcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to issue that is not maturing.")]
    IssueNotMaturing = DTCUnallocatedAdjustmentReasonV2Code.IssueNotMaturing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to items pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_81DcwcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to items pending.")]
    ItemIsPending = DTCUnallocatedAdjustmentReasonV2Code.ItemIsPending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issue is being liquidated.
    /// Encoded/decoded by serializers as &quot;LIQD&quot;.
    /// </summary>
    [EnumMember(Value = "LIQD")]
    [IsoId("_82r0ccMSEee-Vv_OVx0uAQ")]
    [Description(@"Issue is being liquidated.")]
    Liquidation = DTCUnallocatedAdjustmentReasonV2Code.Liquidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to maturity for stock payment option.
    /// Encoded/decoded by serializers as &quot;MSTK&quot;.
    /// </summary>
    [EnumMember(Value = "MSTK")]
    [IsoId("_87c_scMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to maturity for stock payment option.")]
    MaturityForStockPaymentOption =
        DTCUnallocatedAdjustmentReasonV2Code.MaturityForStockPaymentOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notional balance principal will not be paid.
    /// Encoded/decoded by serializers as &quot;NOTL&quot;.
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_888NccMSEee-Vv_OVx0uAQ")]
    [Description(@"Notional balance principal will not be paid.")]
    NotionalBalance = DTCUnallocatedAdjustmentReasonV2Code.NotionalBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to insufficient funds received from the agent.
    /// Encoded/decoded by serializers as &quot;MASF&quot;.
    /// </summary>
    [EnumMember(Value = "MASF")]
    [IsoId("_9SXD0cMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to insufficient funds received from the agent.")]
    InsufficientFundsReceivedFromAgent =
        DTCUnallocatedAdjustmentReasonV2Code.InsufficientFundsReceivedFromAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to funds held at Chase for official foreign asset control.
    /// Encoded/decoded by serializers as &quot;OFAC&quot;.
    /// </summary>
    [EnumMember(Value = "OFAC")]
    [IsoId("_9aY-ccMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to funds held at Chase for official foreign asset control.")]
    FundsHeldAtChaseForOFAC = DTCUnallocatedAdjustmentReasonV2Code.FundsHeldAtChaseForOFAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to a failed bank; Federal Deposit Insurance Corporation assumed.
    /// Encoded/decoded by serializers as &quot;FDIC&quot;.
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_9fdEocMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a failed bank; Federal Deposit Insurance Corporation assumed.")]
    FederalDepositInsuranceCorporation =
        DTCUnallocatedAdjustmentReasonV2Code.FederalDepositInsuranceCorporation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to a church bond not funded.
    /// Encoded/decoded by serializers as &quot;CHBD&quot;.
    /// </summary>
    [EnumMember(Value = "CHBD")]
    [IsoId("_9mSsccMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a church bond not funded.")]
    ChurchBondNotFunded = DTCUnallocatedAdjustmentReasonV2Code.ChurchBondNotFunded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to a CHIPS Payment.
    /// Encoded/decoded by serializers as &quot;CHIP&quot;.
    /// </summary>
    [EnumMember(Value = "CHIP")]
    [IsoId("_9sjFccMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a CHIPS Payment.")]
    CHIPSPayment = DTCUnallocatedAdjustmentReasonV2Code.CHIPSPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHU&quot;.
    /// </summary>
    [EnumMember(Value = "CSHU")]
    [IsoId("_90bPEcMSEee-Vv_OVx0uAQ")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateZero = DTCUnallocatedAdjustmentReasonV2Code.CashRateZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specific issues have been suppressed.
    /// Encoded/decoded by serializers as &quot;PUVF&quot;.
    /// </summary>
    [EnumMember(Value = "PUVF")]
    [IsoId("_-T-R0cMSEee-Vv_OVx0uAQ")]
    [Description(@"Specific issues have been suppressed.")]
    SpecificIssuesSuppressed = DTCUnallocatedAdjustmentReasonV2Code.SpecificIssuesSuppressed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to special distribution and the issue was not funded.
    /// Encoded/decoded by serializers as &quot;SPNF&quot;.
    /// </summary>
    [EnumMember(Value = "SPNF")]
    [IsoId("_-Zec4cMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to special distribution and the issue was not funded.")]
    SpecialDistributionNotYetFunded =
        DTCUnallocatedAdjustmentReasonV2Code.SpecialDistributionNotYetFunded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to same day position capture.
    /// Encoded/decoded by serializers as &quot;SDPC&quot;.
    /// </summary>
    [EnumMember(Value = "SDPC")]
    [IsoId("_-eh8AcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to same day position capture.")]
    SameDayPositionCapture = DTCUnallocatedAdjustmentReasonV2Code.SameDayPositionCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is that due to sale of asset, issue was not funded.
    /// Encoded/decoded by serializers as &quot;SANF&quot;.
    /// </summary>
    [EnumMember(Value = "SANF")]
    [IsoId("_-jmCMcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is that due to sale of asset, issue was not funded.")]
    SaleOfAssetsNotYetFunded = DTCUnallocatedAdjustmentReasonV2Code.SaleOfAssetsNotYetFunded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to released pledge position.
    /// Encoded/decoded by serializers as &quot;RPLG&quot;.
    /// </summary>
    [EnumMember(Value = "RPLG")]
    [IsoId("_-ozSUcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to released pledge position.")]
    ReleasedPledgePosition = DTCUnallocatedAdjustmentReasonV2Code.ReleasedPledgePosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is that due to redemption of rates, issue was not funded.
    /// Encoded/decoded by serializers as &quot;RRNF&quot;.
    /// </summary>
    [EnumMember(Value = "RRNF")]
    [IsoId("_-uAiccMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is that due to redemption of rates, issue was not funded.")]
    RedemptionOfRatesNotYetFunded =
        DTCUnallocatedAdjustmentReasonV2Code.RedemptionOfRatesNotYetFunded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to recapitalisation and issue not funded.
    /// Encoded/decoded by serializers as &quot;RCNF&quot;.
    /// </summary>
    [EnumMember(Value = "RCNF")]
    [IsoId("_-zNykcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to recapitalisation and issue not funded.")]
    RecapitalisationNotFunded = DTCUnallocatedAdjustmentReasonV2Code.RecapitalisationNotFunded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to pledged position.
    /// Encoded/decoded by serializers as &quot;PLEG&quot;.
    /// </summary>
    [EnumMember(Value = "PLEG")]
    [IsoId("_-1JFMcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to pledged position.")]
    PledgedPosition = DTCUnallocatedAdjustmentReasonV2Code.PledgedPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due to pending conversion of funds.
    /// Encoded/decoded by serializers as &quot;RRFX&quot;.
    /// </summary>
    [EnumMember(Value = "RRFX")]
    [IsoId("_-9Lm4cMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to pending conversion of funds.")]
    PendingConversionOfFunds = DTCUnallocatedAdjustmentReasonV2Code.PendingConversionOfFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is due paid upon receipt of check.
    /// Encoded/decoded by serializers as &quot;PCHK&quot;.
    /// </summary>
    [EnumMember(Value = "PCHK")]
    [IsoId("__CF8EcMSEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due paid upon receipt of check.")]
    PaidUponReceiptOfCheck = DTCUnallocatedAdjustmentReasonV2Code.PaidUponReceiptOfCheck, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__IyZ8cMSEee-Vv_OVx0uAQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other = DTCUnallocatedAdjustmentReasonV2Code.Other, // same ordinal as derivation source for type conversions
}
