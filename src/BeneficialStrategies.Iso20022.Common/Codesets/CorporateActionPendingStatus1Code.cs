// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Pending status of the corporate action notification advice coming from the issuer agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pRKX8KUZEfCIzrotrg4VRw")]
[Description(@"Pending status of the corporate action notification advice coming from the issuer agent.")]
[DerivedFrom(typeof(CorporateActionPendingStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CorporateActionPendingStatus1Code>))]
public enum CorporateActionPendingStatus1Code
{
    /// <summary>
    /// Concurrent full call event exists.
    /// Encoded/decoded by serializers as &quot;CNFC&quot;.
    /// </summary>
    [EnumMember(Value = "CNFC")]
    [IsoId("_yXId8aUZEfCIzrotrg4VRw")]
    [Description(@"Concurrent full call event exists.")]
    ConcurrentFullCall = CorporateActionPendingStatusCode.ConcurrentFullCall,

    /// <summary>
    /// Pending due to future publication date.
    /// Encoded/decoded by serializers as &quot;PUBF&quot;.
    /// </summary>
    [EnumMember(Value = "PUBF")]
    [IsoId("_ysDlEaUZEfCIzrotrg4VRw")]
    [Description(@"Pending due to future publication date.")]
    FuturePublicationDate = CorporateActionPendingStatusCode.FuturePublicationDate,

    /// <summary>
    /// Concurrent reorganisation announcement exists.
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_G7bocaUaEfCIzrotrg4VRw")]
    [Description(@"Concurrent reorganisation announcement exists.")]
    ConcurrentReorganisation = CorporateActionPendingStatusCode.ConcurrentReorganisation,

    /// <summary>
    /// Unable to calculate accrued interest. Missing payment details.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_HAnqcaUaEfCIzrotrg4VRw")]
    [Description(@"Unable to calculate accrued interest. Missing payment details.")]
    IncalculableInterest = CorporateActionPendingStatusCode.IncalculableInterest,

    /// <summary>
    /// Invalid Security Called Amount.
    /// Encoded/decoded by serializers as &quot;SCAL&quot;.
    /// </summary>
    [EnumMember(Value = "SCAL")]
    [IsoId("_HHWkkaUaEfCIzrotrg4VRw")]
    [Description(@"Invalid Security Called Amount.")]
    InvalidSecurityCalledAmount = CorporateActionPendingStatusCode.InvalidSecurityCalledAmount,

    /// <summary>
    /// Late announcement. The declared payment date is outside of acceptable range in the past.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_HLKGgaUaEfCIzrotrg4VRw")]
    [Description(@"Late announcement. The declared payment date is outside of acceptable range in the past.")]
    LateAnnouncement = CorporateActionPendingStatusCode.LateAnnouncement,

    /// <summary>
    /// Maturing issue. Redemption date is greater than or equal to maturity date.
    /// Encoded/decoded by serializers as &quot;MATU&quot;.
    /// </summary>
    [EnumMember(Value = "MATU")]
    [IsoId("_HOvmAaUaEfCIzrotrg4VRw")]
    [Description(@"Maturing issue. Redemption date is greater than or equal to maturity date.")]
    MaturingIssue = CorporateActionPendingStatusCode.MaturingIssue,

    /// <summary>
    /// Payable date outside of applicable date range.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_HSVskaUaEfCIzrotrg4VRw")]
    [Description(@"Payable date outside of applicable date range.")]
    PayableDateOutsideRange = CorporateActionPendingStatusCode.PayableDateOutsideRange,

    /// <summary>
    /// Position discrepancy. Potential partial call.
    /// Encoded/decoded by serializers as &quot;POSD&quot;.
    /// </summary>
    [EnumMember(Value = "POSD")]
    [IsoId("_HXddIaUaEfCIzrotrg4VRw")]
    [Description(@"Position discrepancy. Potential partial call.")]
    PositionDiscrepancy = CorporateActionPendingStatusCode.PositionDiscrepancy,

    /// <summary>
    /// Verify event. Potential conflicting partial call exists.
    /// Encoded/decoded by serializers as &quot;CNPC&quot;.
    /// </summary>
    [EnumMember(Value = "CNPC")]
    [IsoId("_HcIhwaUaEfCIzrotrg4VRw")]
    [Description(@"Verify event. Potential conflicting partial call exists.")]
    PotentialPartialCall = CorporateActionPendingStatusCode.PotentialPartialCall,

    /// <summary>
    /// Verify event. Concurrent redemption event exists.
    /// Encoded/decoded by serializers as &quot;CNRD&quot;.
    /// </summary>
    [EnumMember(Value = "CNRD")]
    [IsoId("_HgEmkaUaEfCIzrotrg4VRw")]
    [Description(@"Verify event. Concurrent redemption event exists.")]
    VerifyConcurrentRedemption = CorporateActionPendingStatusCode.VerifyConcurrentRedemption,

    /// <summary>
    /// Verify event. Concurrent reorganisation event exists.
    /// Encoded/decoded by serializers as &quot;CNRE&quot;.
    /// </summary>
    [EnumMember(Value = "CNRE")]
    [IsoId("_HkLDcaUaEfCIzrotrg4VRw")]
    [Description(@"Verify event. Concurrent reorganisation event exists.")]
    VerifyConcurrentReorganisation = CorporateActionPendingStatusCode.VerifyConcurrentReorganisation,

    /// <summary>
    /// Verify rate. On-cycle redemption.
    /// Encoded/decoded by serializers as &quot;VRON&quot;.
    /// </summary>
    [EnumMember(Value = "VRON")]
    [IsoId("_Hpav0aUaEfCIzrotrg4VRw")]
    [Description(@"Verify rate. On-cycle redemption.")]
    VerifyRateRedemption = CorporateActionPendingStatusCode.VerifyRateRedemption,

    /// <summary>
    /// Verify rate. Zero coupon bond.
    /// Encoded/decoded by serializers as &quot;VRZC&quot;.
    /// </summary>
    [EnumMember(Value = "VRZC")]
    [IsoId("_Hsi8UaUaEfCIzrotrg4VRw")]
    [Description(@"Verify rate. Zero coupon bond.")]
    VerifyRateZeroBond = CorporateActionPendingStatusCode.VerifyRateZeroBond,
}
