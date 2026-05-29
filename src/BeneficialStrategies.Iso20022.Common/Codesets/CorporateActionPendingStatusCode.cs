// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Pending status of the corporate action notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wsvAYKUTEfCIzrotrg4VRw")]
[Description(@"Pending status of the corporate action notification.")]
[Derivations(typeof(CorporateActionPendingStatus1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CorporateActionPendingStatusCode>))]
public enum CorporateActionPendingStatusCode
{
    /// <summary>
    /// Unable to calculate accrued interest. Missing payment details.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_iQIFgKUWEfCIzrotrg4VRw")]
    [Description(@"Unable to calculate accrued interest. Missing payment details.")]
    IncalculableInterest,

    /// <summary>
    /// Concurrent full call event exists.
    /// Encoded/decoded by serializers as &quot;CNFC&quot;.
    /// </summary>
    [EnumMember(Value = "CNFC")]
    [IsoId("_BnJLsKUXEfCIzrotrg4VRw")]
    [Description(@"Concurrent full call event exists.")]
    ConcurrentFullCall,

    /// <summary>
    /// Verify event. Potential conflicting partial call exists.
    /// Encoded/decoded by serializers as &quot;CNPC&quot;.
    /// </summary>
    [EnumMember(Value = "CNPC")]
    [IsoId("_Ewx2IKUXEfCIzrotrg4VRw")]
    [Description(@"Verify event. Potential conflicting partial call exists.")]
    PotentialPartialCall,

    /// <summary>
    /// Verify event. Concurrent redemption event exists.
    /// Encoded/decoded by serializers as &quot;CNRD&quot;.
    /// </summary>
    [EnumMember(Value = "CNRD")]
    [IsoId("_IpemAKUXEfCIzrotrg4VRw")]
    [Description(@"Verify event. Concurrent redemption event exists.")]
    VerifyConcurrentRedemption,

    /// <summary>
    /// Verify event. Concurrent reorganisation event exists.
    /// Encoded/decoded by serializers as &quot;CNRE&quot;.
    /// </summary>
    [EnumMember(Value = "CNRE")]
    [IsoId("_LU2nIKUXEfCIzrotrg4VRw")]
    [Description(@"Verify event. Concurrent reorganisation event exists.")]
    VerifyConcurrentReorganisation,

    /// <summary>
    /// Late announcement. The declared payment date is outside of acceptable range in the past.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_OVaOEKUXEfCIzrotrg4VRw")]
    [Description(@"Late announcement. The declared payment date is outside of acceptable range in the past.")]
    LateAnnouncement,

    /// <summary>
    /// Position discrepancy. Potential partial call.
    /// Encoded/decoded by serializers as &quot;POSD&quot;.
    /// </summary>
    [EnumMember(Value = "POSD")]
    [IsoId("_Qz97MKUXEfCIzrotrg4VRw")]
    [Description(@"Position discrepancy. Potential partial call.")]
    PositionDiscrepancy,

    /// <summary>
    /// Pending due to future publication date.
    /// Encoded/decoded by serializers as &quot;PUBF&quot;.
    /// </summary>
    [EnumMember(Value = "PUBF")]
    [IsoId("_U17UwKUXEfCIzrotrg4VRw")]
    [Description(@"Pending due to future publication date.")]
    FuturePublicationDate,

    /// <summary>
    /// Payable date outside of applicable date range.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_YmdnIKUXEfCIzrotrg4VRw")]
    [Description(@"Payable date outside of applicable date range.")]
    PayableDateOutsideRange,

    /// <summary>
    /// Concurrent reorganisation announcement exists.
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_aKlFQKUXEfCIzrotrg4VRw")]
    [Description(@"Concurrent reorganisation announcement exists.")]
    ConcurrentReorganisation,

    /// <summary>
    /// Invalid Security Called Amount.
    /// Encoded/decoded by serializers as &quot;SCAL&quot;.
    /// </summary>
    [EnumMember(Value = "SCAL")]
    [IsoId("_cSjeYKUXEfCIzrotrg4VRw")]
    [Description(@"Invalid Security Called Amount.")]
    InvalidSecurityCalledAmount,

    /// <summary>
    /// Verify rate. On-cycle redemption.
    /// Encoded/decoded by serializers as &quot;VRON&quot;.
    /// </summary>
    [EnumMember(Value = "VRON")]
    [IsoId("_exhbMKUXEfCIzrotrg4VRw")]
    [Description(@"Verify rate. On-cycle redemption.")]
    VerifyRateRedemption,

    /// <summary>
    /// Verify rate. Zero coupon bond.
    /// Encoded/decoded by serializers as &quot;VRZC&quot;.
    /// </summary>
    [EnumMember(Value = "VRZC")]
    [IsoId("_h6Ix8KUXEfCIzrotrg4VRw")]
    [Description(@"Verify rate. Zero coupon bond.")]
    VerifyRateZeroBond,

    /// <summary>
    /// Maturing issue. Redemption date is greater than or equal to maturity date.
    /// Encoded/decoded by serializers as &quot;MATU&quot;.
    /// </summary>
    [EnumMember(Value = "MATU")]
    [IsoId("_kA2m0KUXEfCIzrotrg4VRw")]
    [Description(@"Maturing issue. Redemption date is greater than or equal to maturity date.")]
    MaturingIssue,
}
