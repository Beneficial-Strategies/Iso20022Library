// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXqZ1Np-Ed-ak6NoX_4Aeg_-827273433")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(CancellationProcessingStatusCode))]
public enum CancellationProcessingStatus2Code
{
    /// <summary>
    /// Cancellation has been completed.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bXqZ1dp-Ed-ak6NoX_4Aeg_-827273380")]
    [Description(@"Cancellation has been completed.")]
    CancellationCompleted = CancellationProcessingStatusCode.CancellationCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation is pending. It is not known at this time whether cancellation can be affected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_bXqZ1tp-Ed-ak6NoX_4Aeg_-827273349")]
    [Description(@"Cancellation is pending. It is not known at this time whether cancellation can be affected.")]
    PendingCancellation = CancellationProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_bXqZ19p-Ed-ak6NoX_4Aeg_-827273319")]
    [Description(@"Cancellation will not be executed.")]
    Denied = CancellationProcessingStatusCode.Denied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been acknowledged for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bXqZ2Np-Ed-ak6NoX_4Aeg_-827273257")]
    [Description(@"Cancellation request has been acknowledged for further processing by the account servicer.")]
    Accepted = CancellationProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bXqZ2dp-Ed-ak6NoX_4Aeg_-827272979")]
    [Description(@"Cancellation has been rejected for further processing.")]
    Rejected = CancellationProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
