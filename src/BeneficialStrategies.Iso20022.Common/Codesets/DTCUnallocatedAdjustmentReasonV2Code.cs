// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n3w1hsMQEee-Vv_OVx0uAQ")]
[Description(@"DTC Unallocated reason codes for payment adjustments.")]
[Derivations(typeof(DTCUnallocatedAdjustmentReason4Code))]
public enum DTCUnallocatedAdjustmentReasonV2Code
{
    /// <summary>
    /// Company is taking a 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_n3w1i8MQEee-Vv_OVx0uAQ")]
    [Description(@"Company is taking a 30 day grace period.")]
    GracePeriod,
    
    /// <summary>
    /// Rate is not final. Rate is approximate.
    /// Encoded/decoded by serializers as &quot;APRR&quot;.
    /// </summary>
    [EnumMember(Value = "APRR")]
    [IsoId("_n3xcc8MQEee-Vv_OVx0uAQ")]
    [Description(@"Rate is not final. Rate is approximate.")]
    ApproximateRate,
    
    /// <summary>
    /// Incorrect announcement.
    /// Encoded/decoded by serializers as &quot;ANNG&quot;.
    /// </summary>
    [EnumMember(Value = "ANNG")]
    [IsoId("_n3w1kcMQEee-Vv_OVx0uAQ")]
    [Description(@"Incorrect announcement.")]
    BadAnnouncement,
    
    /// <summary>
    /// Incorrect payable date.
    /// Encoded/decoded by serializers as &quot;BDPD&quot;.
    /// </summary>
    [EnumMember(Value = "BDPD")]
    [IsoId("_n3w1oMMQEee-Vv_OVx0uAQ")]
    [Description(@"Incorrect payable date.")]
    BadPayableDate,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHR&quot;.
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_n3w1kMMQEee-Vv_OVx0uAQ")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateUnknown,
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHU&quot;.
    /// </summary>
    [EnumMember(Value = "CSHU")]
    [IsoId("_n3w1ncMQEee-Vv_OVx0uAQ")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateZero,
    
    /// <summary>
    /// Payment is conditional and conditions have not been met yet.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_n3xcdsMQEee-Vv_OVx0uAQ")]
    [Description(@"Payment is conditional and conditions have not been met yet.")]
    ConditionalPayment,
    
    /// <summary>
    /// Issue is in default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_n3w1ksMQEee-Vv_OVx0uAQ")]
    [Description(@"Issue is in default.")]
    Default,
    
    /// <summary>
    /// Funds were not received by the agent.
    /// Encoded/decoded by serializers as &quot;ANFI&quot;.
    /// </summary>
    [EnumMember(Value = "ANFI")]
    [IsoId("_n3w1ocMQEee-Vv_OVx0uAQ")]
    [Description(@"Funds were not received by the agent.")]
    FundsNotReceivedByAgent,
    
    /// <summary>
    /// Reason is due to holiday in country of origin.
    /// Encoded/decoded by serializers as &quot;HICO&quot;.
    /// </summary>
    [EnumMember(Value = "HICO")]
    [IsoId("_n3w1isMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to holiday in country of origin.")]
    HolidayInCountryOfOrigin,
    
    /// <summary>
    /// Reason is due to insufficient funds received from the agent.
    /// Encoded/decoded by serializers as &quot;MASF&quot;.
    /// </summary>
    [EnumMember(Value = "MASF")]
    [IsoId("_n3xccsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to insufficient funds received from the agent.")]
    InsufficientFundsReceivedFromAgent,
    
    /// <summary>
    /// Reason is due to issue that was not funded.
    /// Encoded/decoded by serializers as &quot;ISNF&quot;.
    /// </summary>
    [EnumMember(Value = "ISNF")]
    [IsoId("_n3w1h8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to issue that was not funded.")]
    IssueNotFunded,
    
    /// <summary>
    /// Reason is due to issue that is not maturing.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_n3xccMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to issue that is not maturing.")]
    IssueNotMaturing,
    
    /// <summary>
    /// Issues funded and/or identified after the cycle cut off.
    /// Encoded/decoded by serializers as &quot;LFID&quot;.
    /// </summary>
    [EnumMember(Value = "LFID")]
    [IsoId("_n3w1lcMQEee-Vv_OVx0uAQ")]
    [Description(@"Issues funded and/or identified after the cycle cut off.")]
    AfterCycleCutOff,
    
    /// <summary>
    /// Reason is due to items pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_n3w1nsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to items pending.")]
    ItemIsPending,
    
    /// <summary>
    /// Issue is being liquidated.
    /// Encoded/decoded by serializers as &quot;LIQD&quot;.
    /// </summary>
    [EnumMember(Value = "LIQD")]
    [IsoId("_n3w1msMQEee-Vv_OVx0uAQ")]
    [Description(@"Issue is being liquidated.")]
    Liquidation,
    
    /// <summary>
    /// Notional balance principal will not be paid.
    /// Encoded/decoded by serializers as &quot;NOTL&quot;.
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_n3w1jMMQEee-Vv_OVx0uAQ")]
    [Description(@"Notional balance principal will not be paid.")]
    NotionalBalance,
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_n3w1icMQEee-Vv_OVx0uAQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,
    
    /// <summary>
    /// Reason is due paid upon receipt of check.
    /// Encoded/decoded by serializers as &quot;PCHK&quot;.
    /// </summary>
    [EnumMember(Value = "PCHK")]
    [IsoId("_n3w1n8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due paid upon receipt of check.")]
    PaidUponReceiptOfCheck,
    
    /// <summary>
    /// Reason is due to pending conversion of funds.
    /// Encoded/decoded by serializers as &quot;RRFX&quot;.
    /// </summary>
    [EnumMember(Value = "RRFX")]
    [IsoId("_n3w1lMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to pending conversion of funds.")]
    PendingConversionOfFunds,
    
    /// <summary>
    /// Reason is due to recapitalisation and issue not funded.
    /// Encoded/decoded by serializers as &quot;RCNF&quot;.
    /// </summary>
    [EnumMember(Value = "RCNF")]
    [IsoId("_n3w1jsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to recapitalisation and issue not funded.")]
    RecapitalisationNotFunded,
    
    /// <summary>
    /// Reason is that due to redemption of rates, issue was not funded.
    /// Encoded/decoded by serializers as &quot;RRNF&quot;.
    /// </summary>
    [EnumMember(Value = "RRNF")]
    [IsoId("_n3w1m8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is that due to redemption of rates, issue was not funded.")]
    RedemptionOfRatesNotYetFunded,
    
    /// <summary>
    /// Reason is due to released pledge position.
    /// Encoded/decoded by serializers as &quot;RPLG&quot;.
    /// </summary>
    [EnumMember(Value = "RPLG")]
    [IsoId("_n3w1mcMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to released pledge position.")]
    ReleasedPledgePosition,
    
    /// <summary>
    /// Reason is that due to sale of asset, issue was not funded.
    /// Encoded/decoded by serializers as &quot;SANF&quot;.
    /// </summary>
    [EnumMember(Value = "SANF")]
    [IsoId("_n3w1mMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is that due to sale of asset, issue was not funded.")]
    SaleOfAssetsNotYetFunded,
    
    /// <summary>
    /// Reason is due to same day position capture.
    /// Encoded/decoded by serializers as &quot;SDPC&quot;.
    /// </summary>
    [EnumMember(Value = "SDPC")]
    [IsoId("_n3w1nMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to same day position capture.")]
    SameDayPositionCapture,
    
    /// <summary>
    /// Reason is due to special distribution and the issue was not funded.
    /// Encoded/decoded by serializers as &quot;SPNF&quot;.
    /// </summary>
    [EnumMember(Value = "SPNF")]
    [IsoId("_n3xcccMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to special distribution and the issue was not funded.")]
    SpecialDistributionNotYetFunded,
    
    /// <summary>
    /// Specific issues have been suppressed.
    /// Encoded/decoded by serializers as &quot;PUVF&quot;.
    /// </summary>
    [EnumMember(Value = "PUVF")]
    [IsoId("_n3w1osMQEee-Vv_OVx0uAQ")]
    [Description(@"Specific issues have been suppressed.")]
    SpecificIssuesSuppressed,
    
    /// <summary>
    /// Reason is due to a call rescinded.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_n3w1jcMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a call rescinded.")]
    CallRescinded,
    
    /// <summary>
    /// Reason is due to a CD accelerated maturity.
    /// Encoded/decoded by serializers as &quot;ERLY&quot;.
    /// </summary>
    [EnumMember(Value = "ERLY")]
    [IsoId("_n3w1j8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a CD accelerated maturity.")]
    CDAcceleratedMaturity,
    
    /// <summary>
    /// Reason is due to a CHIPS Payment.
    /// Encoded/decoded by serializers as &quot;CHIP&quot;.
    /// </summary>
    [EnumMember(Value = "CHIP")]
    [IsoId("_n3xcd8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a CHIPS Payment.")]
    CHIPSPayment,
    
    /// <summary>
    /// Reason is due to a five day grace period.
    /// Encoded/decoded by serializers as &quot;FVDG&quot;.
    /// </summary>
    [EnumMember(Value = "FVDG")]
    [IsoId("_n3w1lsMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a five day grace period.")]
    FiveDayGracePeriod,
    
    /// <summary>
    /// Reason is due to a failed bank; Federal Deposit Insurance Corporation assumed.
    /// Encoded/decoded by serializers as &quot;FDIC&quot;.
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_n3w1iMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a failed bank; Federal Deposit Insurance Corporation assumed.")]
    FederalDepositInsuranceCorporation,
    
    /// <summary>
    /// Reason is due to pledged position.
    /// Encoded/decoded by serializers as &quot;PLEG&quot;.
    /// </summary>
    [EnumMember(Value = "PLEG")]
    [IsoId("_n3xcdMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to pledged position.")]
    PledgedPosition,
    
    /// <summary>
    /// Reason is due to maturity for stock payment option.
    /// Encoded/decoded by serializers as &quot;MSTK&quot;.
    /// </summary>
    [EnumMember(Value = "MSTK")]
    [IsoId("_n3xcdcMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to maturity for stock payment option.")]
    MaturityForStockPaymentOption,
    
    /// <summary>
    /// Reason is due to a church bond not funded.
    /// Encoded/decoded by serializers as &quot;CHBD&quot;.
    /// </summary>
    [EnumMember(Value = "CHBD")]
    [IsoId("_n3w1k8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a church bond not funded.")]
    ChurchBondNotFunded,
    
    /// <summary>
    /// Reason is due to funds held at Chase for official foreign asset control.
    /// Encoded/decoded by serializers as &quot;OFAC&quot;.
    /// </summary>
    [EnumMember(Value = "OFAC")]
    [IsoId("_n3w1l8MQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to funds held at Chase for official foreign asset control.")]
    FundsHeldAtChaseForOFAC,
    
    /// <summary>
    /// Reason is due to a Canadian depository inventory.
    /// Encoded/decoded by serializers as &quot;CDIN&quot;.
    /// </summary>
    [EnumMember(Value = "CDIN")]
    [IsoId("_n3xceMMQEee-Vv_OVx0uAQ")]
    [Description(@"Reason is due to a Canadian depository inventory.")]
    CanadianDepositoryInventory,
    
}
