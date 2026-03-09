// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a meeting instruction cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpiZZdp-Ed-ak6NoX_4Aeg_-1337126365")]
[Description(@"Status of a meeting instruction cancellation request.")]
[DerivedFrom(typeof(MeetingInstructionCancellationStatusCode))]
public enum MeetingInstructionCancellationStatus1Code
{
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_VpiZZtp-Ed-ak6NoX_4Aeg_-1092392896")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted = MeetingInstructionCancellationStatusCode.CancellationCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be executed.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_VpiZZ9p-Ed-ak6NoX_4Aeg_-1068378433")]
    [Description(@"Cancellation is pending. It is not known at this time whether cancellation can be executed.")]
    PendingCancellation = MeetingInstructionCancellationStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation will not be executed due to business reasons.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_VpiZaNp-Ed-ak6NoX_4Aeg_-1051757850")]
    [Description(@"Cancellation will not be executed due to business reasons.")]
    CancellationDenied = MeetingInstructionCancellationStatusCode.CancellationDenied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected for further processing due to system (data) reasons.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_VpsKYNp-Ed-ak6NoX_4Aeg_-1009275976")]
    [Description(@"Cancellation request has been rejected for further processing due to system (data) reasons.")]
    CancellationRejected = MeetingInstructionCancellationStatusCode.CancellationRejected, // same ordinal as derivation source for type conversions
    
}
