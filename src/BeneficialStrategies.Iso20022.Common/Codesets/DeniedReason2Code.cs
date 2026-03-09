// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_az5ledp-Ed-ak6NoX_4Aeg_363272961")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(DeniedReasonCode))]
public enum DeniedReason2Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_a0CvYNp-Ed-ak6NoX_4Aeg_363272993")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed = DeniedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as &quot;DCAL&quot;.
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_a0CvYdp-Ed-ak6NoX_4Aeg_363273023")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied = DeniedReasonCode.CallDeniedSinceAlreadyApplied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_a0CvYtp-Ed-ak6NoX_4Aeg_364193017")]
    [Description(@"Cancellation request was denied since the instruction has already been cancelled.")]
    DeniedSinceAlreadyCancelled = DeniedReasonCode.DeniedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_a0CvY9p-Ed-ak6NoX_4Aeg_364193018")]
    [Description(@"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.")]
    DeniedSinceNotAllowed = DeniedReasonCode.DeniedSinceNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied because the process of settlement is in progress.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_a0CvZNp-Ed-ak6NoX_4Aeg_364193048")]
    [Description(@"Cancellation request was denied because the process of settlement is in progress.")]
    DeniedSinceInProgress = DeniedReasonCode.DeniedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied because the repo was cancelled.
    /// Encoded/decoded by serializers as &quot;DREP&quot;.
    /// </summary>
    [EnumMember(Value = "DREP")]
    [IsoId("_a0CvZdp-Ed-ak6NoX_4Aeg_364193078")]
    [Description(@"Cancellation request was denied because the repo was cancelled.")]
    DeniedSinceRepoEnded = DeniedReasonCode.DeniedSinceRepoEnded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_a0CvZtp-Ed-ak6NoX_4Aeg_364193079")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled = DeniedReasonCode.DeniedSinceAlreadySettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_a0CvZ9p-Ed-ak6NoX_4Aeg_364193140")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = DeniedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
}
