// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQNIme5NEeCisYr99QEiWA_-1920216979")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(CancellationProcessingStatusCode))]
public enum CancellationProcessingStatus3Code
{
    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be affected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_jQW5kO5NEeCisYr99QEiWA_1377677964")]
    [Description(@"Cancellation is pending. It is not known at this time whether cancellation can be affected.")]
    PendingCancellation = CancellationProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_jQW5ke5NEeCisYr99QEiWA_1441957570")]
    [Description(@"Cancellation has been rejected for further processing.")]
    Rejected = CancellationProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_jQW5ku5NEeCisYr99QEiWA_-653311621")]
    [Description(@"Cancellation request is in repair.")]
    InRepair = CancellationProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been acknowledged for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_jQW5k-5NEeCisYr99QEiWA_1263838898")]
    [Description(@"Cancellation request has been acknowledged for further processing by the account servicer.")]
    Accepted = CancellationProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_jQW5lO5NEeCisYr99QEiWA_1555796636")]
    [Description(@"Cancellation will not be executed.")]
    Denied = CancellationProcessingStatusCode.Denied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_jQgqkO5NEeCisYr99QEiWA_-1855937373")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted = CancellationProcessingStatusCode.CancellationCompleted, // same ordinal as derivation source for type conversions
    
}
