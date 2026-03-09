// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u7JFsZEsEeajS_7NioJdVA")]
[Description(@"DTC Unallocated reason codes for payment adjustments.")]
[DerivedFrom(typeof(DTCUnallocatedAdjustmentReasonCode))]
public enum DTCUnallocatedAdjustmentReason3Code
{
    /// <summary>
    /// Incorrect announcement.
    /// Encoded/decoded by serializers as &quot;ANNG&quot;.
    /// </summary>
    [EnumMember(Value = "ANNG")]
    [IsoId("_vTPcoZEsEeajS_7NioJdVA")]
    [Description(@"Incorrect announcement.")]
    BadAnnouncement = DTCUnallocatedAdjustmentReasonCode.BadAnnouncement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Incorrect payable date.
    /// Encoded/decoded by serializers as &quot;BDPD&quot;.
    /// </summary>
    [EnumMember(Value = "BDPD")]
    [IsoId("_vTPco5EsEeajS_7NioJdVA")]
    [Description(@"Incorrect payable date.")]
    BadPayableDate = DTCUnallocatedAdjustmentReasonCode.BadPayableDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHR&quot;.
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_vTPcpZEsEeajS_7NioJdVA")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateUnknown = DTCUnallocatedAdjustmentReasonCode.CashRateUnknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHU&quot;.
    /// </summary>
    [EnumMember(Value = "CSHU")]
    [IsoId("_vTPcp5EsEeajS_7NioJdVA")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateZero = DTCUnallocatedAdjustmentReasonCode.CashRateZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is conditional and conditions have not been met yet.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_vTPcqZEsEeajS_7NioJdVA")]
    [Description(@"Payment is conditional and conditions have not been met yet.")]
    ConditionalPayment = DTCUnallocatedAdjustmentReasonCode.ConditionalPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue is in default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_vTPcq5EsEeajS_7NioJdVA")]
    [Description(@"Issue is in default.")]
    Default = DTCUnallocatedAdjustmentReasonCode.Default, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holiday in country of origin.
    /// Encoded/decoded by serializers as &quot;HICO&quot;.
    /// </summary>
    [EnumMember(Value = "HICO")]
    [IsoId("_vTPcrZEsEeajS_7NioJdVA")]
    [Description(@"Holiday in country of origin.")]
    HolidayInCountryOfOrigin = DTCUnallocatedAdjustmentReasonCode.HolidayInCountryOfOrigin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient funds were received from the agent.
    /// Encoded/decoded by serializers as &quot;MASF&quot;.
    /// </summary>
    [EnumMember(Value = "MASF")]
    [IsoId("_vTPcr5EsEeajS_7NioJdVA")]
    [Description(@"Insufficient funds were received from the agent.")]
    InsufficientFundsReceivedFromAgent = DTCUnallocatedAdjustmentReasonCode.InsufficientFundsReceivedFromAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue was not funded.
    /// Encoded/decoded by serializers as &quot;ISNF&quot;.
    /// </summary>
    [EnumMember(Value = "ISNF")]
    [IsoId("_vTPcsZEsEeajS_7NioJdVA")]
    [Description(@"Issue was not funded.")]
    IssueNotFunded = DTCUnallocatedAdjustmentReasonCode.IssueNotFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue is not maturing.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_vTPcs5EsEeajS_7NioJdVA")]
    [Description(@"Issue is not maturing.")]
    IssueNotMaturing = DTCUnallocatedAdjustmentReasonCode.IssueNotMaturing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issues funded and/or identified after the cycle cut off.
    /// Encoded/decoded by serializers as &quot;LFID&quot;.
    /// </summary>
    [EnumMember(Value = "LFID")]
    [IsoId("_vTPctZEsEeajS_7NioJdVA")]
    [Description(@"Issues funded and/or identified after the cycle cut off.")]
    AfterCycleCutOff = DTCUnallocatedAdjustmentReasonCode.AfterCycleCutOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Item is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_vTPct5EsEeajS_7NioJdVA")]
    [Description(@"Item is pending.")]
    ItemIsPending = DTCUnallocatedAdjustmentReasonCode.ItemIsPending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds were not received by the agent.
    /// Encoded/decoded by serializers as &quot;ANFI&quot;.
    /// </summary>
    [EnumMember(Value = "ANFI")]
    [IsoId("_vTPcuZEsEeajS_7NioJdVA")]
    [Description(@"Funds were not received by the agent.")]
    FundsNotReceivedByAgent = DTCUnallocatedAdjustmentReasonCode.FundsNotReceivedByAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue is being liquidated.
    /// Encoded/decoded by serializers as &quot;LIQD&quot;.
    /// </summary>
    [EnumMember(Value = "LIQD")]
    [IsoId("_vTPcu5EsEeajS_7NioJdVA")]
    [Description(@"Issue is being liquidated.")]
    Liquidation = DTCUnallocatedAdjustmentReasonCode.Liquidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notional balance pincipal will not be paid.
    /// Encoded/decoded by serializers as &quot;NOTL&quot;.
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_vTPcvZEsEeajS_7NioJdVA")]
    [Description(@"Notional balance pincipal will not be paid.")]
    NotionalBalance = DTCUnallocatedAdjustmentReasonCode.NotionalBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_vTPcv5EsEeajS_7NioJdVA")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other = DTCUnallocatedAdjustmentReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Paid upon receipt of check.
    /// Encoded/decoded by serializers as &quot;PCHK&quot;.
    /// </summary>
    [EnumMember(Value = "PCHK")]
    [IsoId("_vTPcwZEsEeajS_7NioJdVA")]
    [Description(@"Paid upon receipt of check.")]
    PaidUponReceiptOfCheck = DTCUnallocatedAdjustmentReasonCode.PaidUponReceiptOfCheck, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending conversion of funds.
    /// Encoded/decoded by serializers as &quot;RRFX&quot;.
    /// </summary>
    [EnumMember(Value = "RRFX")]
    [IsoId("_vTPcw5EsEeajS_7NioJdVA")]
    [Description(@"Pending conversion of funds.")]
    PendingConversionOfFunds = DTCUnallocatedAdjustmentReasonCode.PendingConversionOfFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recapitalization. Issue not funded.
    /// Encoded/decoded by serializers as &quot;RCNF&quot;.
    /// </summary>
    [EnumMember(Value = "RCNF")]
    [IsoId("_vTPcxZEsEeajS_7NioJdVA")]
    [Description(@"Recapitalization. Issue not funded.")]
    RecapitalizationNotFunded = DTCUnallocatedAdjustmentReasonCode.RecapitalizationNotFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption of rates. Issue not funded.
    /// Encoded/decoded by serializers as &quot;RRNF&quot;.
    /// </summary>
    [EnumMember(Value = "RRNF")]
    [IsoId("_vTPcx5EsEeajS_7NioJdVA")]
    [Description(@"Redemption of rates. Issue not funded.")]
    RedemptionOfRatesNotYetFunded = DTCUnallocatedAdjustmentReasonCode.RedemptionOfRatesNotYetFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Released pledge position.
    /// Encoded/decoded by serializers as &quot;RPLG&quot;.
    /// </summary>
    [EnumMember(Value = "RPLG")]
    [IsoId("_vTPcyZEsEeajS_7NioJdVA")]
    [Description(@"Released pledge position.")]
    ReleasedPledgePosition = DTCUnallocatedAdjustmentReasonCode.ReleasedPledgePosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sale of asset. Issue not funded.
    /// Encoded/decoded by serializers as &quot;SANF&quot;.
    /// </summary>
    [EnumMember(Value = "SANF")]
    [IsoId("_vTPcy5EsEeajS_7NioJdVA")]
    [Description(@"Sale of asset. Issue not funded.")]
    SaleOfAssetsNotYetFunded = DTCUnallocatedAdjustmentReasonCode.SaleOfAssetsNotYetFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Same day position capture.
    /// Encoded/decoded by serializers as &quot;SDPC&quot;.
    /// </summary>
    [EnumMember(Value = "SDPC")]
    [IsoId("_vTPczZEsEeajS_7NioJdVA")]
    [Description(@"Same day position capture.")]
    SameDayPositionCapture = DTCUnallocatedAdjustmentReasonCode.SameDayPositionCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Special distribution. Issue not funded.
    /// Encoded/decoded by serializers as &quot;SPNF&quot;.
    /// </summary>
    [EnumMember(Value = "SPNF")]
    [IsoId("_vTPcz5EsEeajS_7NioJdVA")]
    [Description(@"Special distribution. Issue not funded.")]
    SpecialDistributionNotYetFunded = DTCUnallocatedAdjustmentReasonCode.SpecialDistributionNotYetFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specific issues have been suppressed.
    /// Encoded/decoded by serializers as &quot;PUVF&quot;.
    /// </summary>
    [EnumMember(Value = "PUVF")]
    [IsoId("_vTPc0ZEsEeajS_7NioJdVA")]
    [Description(@"Specific issues have been suppressed.")]
    SpecificIssuesSuppressed = DTCUnallocatedAdjustmentReasonCode.SpecificIssuesSuppressed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is not final. Rate is approximate.
    /// Encoded/decoded by serializers as &quot;APRR&quot;.
    /// </summary>
    [EnumMember(Value = "APRR")]
    [IsoId("_vTPc05EsEeajS_7NioJdVA")]
    [Description(@"Rate is not final. Rate is approximate.")]
    ApproximateRate = DTCUnallocatedAdjustmentReasonCode.ApproximateRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Company is taking a 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_vTPc1ZEsEeajS_7NioJdVA")]
    [Description(@"Company is taking a 30 day grace period.")]
    GracePeriod = DTCUnallocatedAdjustmentReasonCode.GracePeriod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maturity for stock payment option.
    /// Encoded/decoded by serializers as &quot;MSTK&quot;.
    /// </summary>
    [EnumMember(Value = "MSTK")]
    [IsoId("_vTPc15EsEeajS_7NioJdVA")]
    [Description(@"Maturity for stock payment option.")]
    MaturityForStockPaymentOption = DTCUnallocatedAdjustmentReasonCode.MaturityForStockPaymentOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pledged Position.
    /// Encoded/decoded by serializers as &quot;PLEG&quot;.
    /// </summary>
    [EnumMember(Value = "PLEG")]
    [IsoId("_vTPc2ZEsEeajS_7NioJdVA")]
    [Description(@"Pledged Position.")]
    PledgedPosition = DTCUnallocatedAdjustmentReasonCode.PledgedPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Call Rescinded.
    /// Encoded/decoded by serializers as &quot;RESC&quot;.
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_vTPc25EsEeajS_7NioJdVA")]
    [Description(@"Call Rescinded.")]
    CallRescinded = DTCUnallocatedAdjustmentReasonCode.CallRescinded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CD Accelerated Maturity.
    /// Encoded/decoded by serializers as &quot;ERLY&quot;.
    /// </summary>
    [EnumMember(Value = "ERLY")]
    [IsoId("_vTPc3ZEsEeajS_7NioJdVA")]
    [Description(@"CD Accelerated Maturity.")]
    CDAcceleratedMaturity = DTCUnallocatedAdjustmentReasonCode.CDAcceleratedMaturity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CHIPS Payment.
    /// Encoded/decoded by serializers as &quot;CHIP&quot;.
    /// </summary>
    [EnumMember(Value = "CHIP")]
    [IsoId("_vTPc35EsEeajS_7NioJdVA")]
    [Description(@"CHIPS Payment.")]
    CHIPSPayment = DTCUnallocatedAdjustmentReasonCode.CHIPSPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Church bond not funded.
    /// Encoded/decoded by serializers as &quot;CHBD&quot;.
    /// </summary>
    [EnumMember(Value = "CHBD")]
    [IsoId("_vTPc4ZEsEeajS_7NioJdVA")]
    [Description(@"Church bond not funded.")]
    ChurchBondNotFunded = DTCUnallocatedAdjustmentReasonCode.ChurchBondNotFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Failed Bank, FDIC Assumed.
    /// Encoded/decoded by serializers as &quot;FDIC&quot;.
    /// </summary>
    [EnumMember(Value = "FDIC")]
    [IsoId("_vTPc45EsEeajS_7NioJdVA")]
    [Description(@"Failed Bank, FDIC Assumed.")]
    FDIC = DTCUnallocatedAdjustmentReasonCode.FDIC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Five Day Grace Period.
    /// Encoded/decoded by serializers as &quot;FVDG&quot;.
    /// </summary>
    [EnumMember(Value = "FVDG")]
    [IsoId("_vTPc5ZEsEeajS_7NioJdVA")]
    [Description(@"Five Day Grace Period.")]
    FiveDayGracePeriod = DTCUnallocatedAdjustmentReasonCode.FiveDayGracePeriod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds held at Chase for OFAC.
    /// Encoded/decoded by serializers as &quot;OFAC&quot;.
    /// </summary>
    [EnumMember(Value = "OFAC")]
    [IsoId("_vTPc55EsEeajS_7NioJdVA")]
    [Description(@"Funds held at Chase for OFAC.")]
    FundsHeldAtChaseForOFAC = DTCUnallocatedAdjustmentReasonCode.FundsHeldAtChaseForOFAC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Canadian depository inventory.
    /// Encoded/decoded by serializers as &quot;CDIN&quot;.
    /// </summary>
    [EnumMember(Value = "CDIN")]
    [IsoId("_0KVucZEsEeajS_7NioJdVA")]
    [Description(@"Canadian depository inventory.")]
    CanadianDepositoryInventory = DTCUnallocatedAdjustmentReasonCode.CanadianDepositoryInventory, // same ordinal as derivation source for type conversions
    
}
