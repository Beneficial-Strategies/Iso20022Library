// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a meeting instruction cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpiZYNp-Ed-ak6NoX_4Aeg_-1662861442")]
[Description(@"Status of a meeting instruction cancellation request.")]
[Derivations(typeof(MeetingInstructionCancellationStatus1Code))]
public enum MeetingInstructionCancellationStatusCode
{
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_VpiZYdp-Ed-ak6NoX_4Aeg_1796054566")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted,
    
    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be executed.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_VpiZYtp-Ed-ak6NoX_4Aeg_2029705192")]
    [Description(@"Cancellation is pending. It is not known at this time whether cancellation can be executed.")]
    PendingCancellation,
    
    /// <summary>
    /// Cancellation will not be executed due to business reasons.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_VpiZY9p-Ed-ak6NoX_4Aeg_-1981741169")]
    [Description(@"Cancellation will not be executed due to business reasons.")]
    CancellationDenied,
    
    /// <summary>
    /// Cancellation request has been rejected for further processing due to system (data) reasons.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_VpiZZNp-Ed-ak6NoX_4Aeg_-1596634915")]
    [Description(@"Cancellation request has been rejected for further processing due to system (data) reasons.")]
    CancellationRejected,
    
}
