// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC Unallocated reason codes for payment adjustments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-HWBAGiLEeOdXoiw6mfXMw")]
[Description(@"DTC Unallocated reason codes for payment adjustments.")]
[DerivedFrom(typeof(DTCUnallocatedAdjustmentReasonCode))]
public enum DTCUnallocatedAdjustmentReason1Code
{
    /// <summary>
    /// Incorrect announcement.
    /// Encoded/decoded by serializers as &quot;ANNG&quot;.
    /// </summary>
    [EnumMember(Value = "ANNG")]
    [IsoId("_O32pcWiPEeOdXoiw6mfXMw")]
    [Description(@"Incorrect announcement.")]
    BadAnnouncement = DTCUnallocatedAdjustmentReasonCode.BadAnnouncement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Incorrect payable date.
    /// Encoded/decoded by serializers as &quot;BDPD&quot;.
    /// </summary>
    [EnumMember(Value = "BDPD")]
    [IsoId("_O6PPEWiPEeOdXoiw6mfXMw")]
    [Description(@"Incorrect payable date.")]
    BadPayableDate = DTCUnallocatedAdjustmentReasonCode.BadPayableDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHR&quot;.
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_O8w-oWiPEeOdXoiw6mfXMw")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateUnknown = DTCUnallocatedAdjustmentReasonCode.CashRateUnknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash rate for allocation is zero.
    /// Encoded/decoded by serializers as &quot;CSHU&quot;.
    /// </summary>
    [EnumMember(Value = "CSHU")]
    [IsoId("_O_JkQWiPEeOdXoiw6mfXMw")]
    [Description(@"Cash rate for allocation is zero.")]
    CashRateZero = DTCUnallocatedAdjustmentReasonCode.CashRateZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is conditional and conditions have not been met yet.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_PG4j8WiPEeOdXoiw6mfXMw")]
    [Description(@"Payment is conditional and conditions have not been met yet.")]
    ConditionalPayment = DTCUnallocatedAdjustmentReasonCode.ConditionalPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue is in default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_PJRJkWiPEeOdXoiw6mfXMw")]
    [Description(@"Issue is in default.")]
    Default = DTCUnallocatedAdjustmentReasonCode.Default, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holiday in country of origin.
    /// Encoded/decoded by serializers as &quot;HICO&quot;.
    /// </summary>
    [EnumMember(Value = "HICO")]
    [IsoId("_PVm8cWiPEeOdXoiw6mfXMw")]
    [Description(@"Holiday in country of origin.")]
    HolidayInCountryOfOrigin = DTCUnallocatedAdjustmentReasonCode.HolidayInCountryOfOrigin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient funds were received from the agent.
    /// Encoded/decoded by serializers as &quot;MASF&quot;.
    /// </summary>
    [EnumMember(Value = "MASF")]
    [IsoId("_PX_iEWiPEeOdXoiw6mfXMw")]
    [Description(@"Insufficient funds were received from the agent.")]
    InsufficientFundsReceivedFromAgent = DTCUnallocatedAdjustmentReasonCode.InsufficientFundsReceivedFromAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue was not funded.
    /// Encoded/decoded by serializers as &quot;ISNF&quot;.
    /// </summary>
    [EnumMember(Value = "ISNF")]
    [IsoId("_PfR10WiPEeOdXoiw6mfXMw")]
    [Description(@"Issue was not funded.")]
    IssueNotFunded = DTCUnallocatedAdjustmentReasonCode.IssueNotFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue is not maturing.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_Pmt6kWiPEeOdXoiw6mfXMw")]
    [Description(@"Issue is not maturing.")]
    IssueNotMaturing = DTCUnallocatedAdjustmentReasonCode.IssueNotMaturing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issues funded and/or identified after the cycle cut off.
    /// Encoded/decoded by serializers as &quot;LFID&quot;.
    /// </summary>
    [EnumMember(Value = "LFID")]
    [IsoId("_Pt3EYWiPEeOdXoiw6mfXMw")]
    [Description(@"Issues funded and/or identified after the cycle cut off.")]
    AfterCycleCutOff = DTCUnallocatedAdjustmentReasonCode.AfterCycleCutOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Item is pending.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_PwYz8WiPEeOdXoiw6mfXMw")]
    [Description(@"Item is pending.")]
    ItemIsPending = DTCUnallocatedAdjustmentReasonCode.ItemIsPending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds were not received by the agent.
    /// Encoded/decoded by serializers as &quot;ANFI&quot;.
    /// </summary>
    [EnumMember(Value = "ANFI")]
    [IsoId("_QjuVYWiPEeOdXoiw6mfXMw")]
    [Description(@"Funds were not received by the agent.")]
    FundsNotReceivedByAgent = DTCUnallocatedAdjustmentReasonCode.FundsNotReceivedByAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue is being liquidated.
    /// Encoded/decoded by serializers as &quot;LIQD&quot;.
    /// </summary>
    [EnumMember(Value = "LIQD")]
    [IsoId("_Q5cGsWiPEeOdXoiw6mfXMw")]
    [Description(@"Issue is being liquidated.")]
    Liquidation = DTCUnallocatedAdjustmentReasonCode.Liquidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notional balance pincipal will not be paid.
    /// Encoded/decoded by serializers as &quot;NOTL&quot;.
    /// </summary>
    [EnumMember(Value = "NOTL")]
    [IsoId("_Q70sUWiPEeOdXoiw6mfXMw")]
    [Description(@"Notional balance pincipal will not be paid.")]
    NotionalBalance = DTCUnallocatedAdjustmentReasonCode.NotionalBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_RDHAEWiPEeOdXoiw6mfXMw")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other = DTCUnallocatedAdjustmentReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Paid upon receipt of check.
    /// Encoded/decoded by serializers as &quot;PCHK&quot;.
    /// </summary>
    [EnumMember(Value = "PCHK")]
    [IsoId("_RKZ64WiPEeOdXoiw6mfXMw")]
    [Description(@"Paid upon receipt of check.")]
    PaidUponReceiptOfCheck = DTCUnallocatedAdjustmentReasonCode.PaidUponReceiptOfCheck, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending conversion of funds.
    /// Encoded/decoded by serializers as &quot;RRFX&quot;.
    /// </summary>
    [EnumMember(Value = "RRFX")]
    [IsoId("_RMx5cWiPEeOdXoiw6mfXMw")]
    [Description(@"Pending conversion of funds.")]
    PendingConversionOfFunds = DTCUnallocatedAdjustmentReasonCode.PendingConversionOfFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recapitalization. Issue not funded.
    /// Encoded/decoded by serializers as &quot;RCNF&quot;.
    /// </summary>
    [EnumMember(Value = "RCNF")]
    [IsoId("_RPKfEWiPEeOdXoiw6mfXMw")]
    [Description(@"Recapitalization. Issue not funded.")]
    RecapitalizationNotFunded = DTCUnallocatedAdjustmentReasonCode.RecapitalizationNotFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption of rates. Issue not funded.
    /// Encoded/decoded by serializers as &quot;RRNF&quot;.
    /// </summary>
    [EnumMember(Value = "RRNF")]
    [IsoId("_RWcy0WiPEeOdXoiw6mfXMw")]
    [Description(@"Redemption of rates. Issue not funded.")]
    RedemptionOfRatesNotYetFunded = DTCUnallocatedAdjustmentReasonCode.RedemptionOfRatesNotYetFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Released pledge position.
    /// Encoded/decoded by serializers as &quot;RPLG&quot;.
    /// </summary>
    [EnumMember(Value = "RPLG")]
    [IsoId("_SOGMgWiPEeOdXoiw6mfXMw")]
    [Description(@"Released pledge position.")]
    ReleasedPledgePosition = DTCUnallocatedAdjustmentReasonCode.ReleasedPledgePosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sale of asset. Issue not funded.
    /// Encoded/decoded by serializers as &quot;SANF&quot;.
    /// </summary>
    [EnumMember(Value = "SANF")]
    [IsoId("_SQn8EWiPEeOdXoiw6mfXMw")]
    [Description(@"Sale of asset. Issue not funded.")]
    SaleOfAssetsNotYetFunded = DTCUnallocatedAdjustmentReasonCode.SaleOfAssetsNotYetFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Same day position capture.
    /// Encoded/decoded by serializers as &quot;SDPC&quot;.
    /// </summary>
    [EnumMember(Value = "SDPC")]
    [IsoId("_STAhsWiPEeOdXoiw6mfXMw")]
    [Description(@"Same day position capture.")]
    SameDayPositionCapture = DTCUnallocatedAdjustmentReasonCode.SameDayPositionCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Special distribution. Issue not funded.
    /// Encoded/decoded by serializers as &quot;SPNF&quot;.
    /// </summary>
    [EnumMember(Value = "SPNF")]
    [IsoId("_SaJrgWiPEeOdXoiw6mfXMw")]
    [Description(@"Special distribution. Issue not funded.")]
    SpecialDistributionNotYetFunded = DTCUnallocatedAdjustmentReasonCode.SpecialDistributionNotYetFunded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specific issues have been suppressed.
    /// Encoded/decoded by serializers as &quot;PUVF&quot;.
    /// </summary>
    [EnumMember(Value = "PUVF")]
    [IsoId("_SchqEWiPEeOdXoiw6mfXMw")]
    [Description(@"Specific issues have been suppressed.")]
    SpecificIssuesSuppressed = DTCUnallocatedAdjustmentReasonCode.SpecificIssuesSuppressed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is not final. Rate is approximate.
    /// Encoded/decoded by serializers as &quot;APRR&quot;.
    /// </summary>
    [EnumMember(Value = "APRR")]
    [IsoId("_Sjqz4WiPEeOdXoiw6mfXMw")]
    [Description(@"Rate is not final. Rate is approximate.")]
    ApproximateRate = DTCUnallocatedAdjustmentReasonCode.ApproximateRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Company is taking a 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_SmDZgWiPEeOdXoiw6mfXMw")]
    [Description(@"Company is taking a 30 day grace period.")]
    GracePeriod = DTCUnallocatedAdjustmentReasonCode.GracePeriod, // same ordinal as derivation source for type conversions
    
}
