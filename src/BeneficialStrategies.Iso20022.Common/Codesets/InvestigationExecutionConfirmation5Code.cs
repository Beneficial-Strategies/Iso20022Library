// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status on an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C7DOoB08EeiYoZGjIMHr2A")]
[Description(@"Provides the status on an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
public enum InvestigationExecutionConfirmation5Code
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_S-p1IR08EeiYoZGjIMHr2A")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest = InvestigationExecutionConfirmationCode.CancelledAsPerRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_Uebl0h08EeiYoZGjIMHr2A")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest = InvestigationExecutionConfirmationCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_VBa-Ih08EeiYoZGjIMHr2A")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest = InvestigationExecutionConfirmationCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
}
