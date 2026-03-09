// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a corporate action instruction cancellation process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKGe-Np-Ed-ak6NoX_4Aeg_777626123")]
[Description(@"Specifies the status of a corporate action instruction cancellation process.")]
[DerivedFrom(typeof(CorporateActionInstructionCancellationProcessingStatusCode))]
public enum CorporateActionInstructionCancellationProcessingStatus1Code
{
    /// <summary>
    /// Cancellation request has been completed.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_bKPo4Np-Ed-ak6NoX_4Aeg_-711137955")]
    [Description(@"Cancellation request has been completed.")]
    CancellationCompleted = CorporateActionInstructionCancellationProcessingStatusCode.CancellationCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is pending. It is not known at this time whether cancellation can be affected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_bKPo4dp-Ed-ak6NoX_4Aeg_-1054212063")]
    [Description(@"Cancellation request is pending. It is not known at this time whether cancellation can be affected.")]
    PendingCancellation = CorporateActionInstructionCancellationProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_bKPo4tp-Ed-ak6NoX_4Aeg_620854078")]
    [Description(@"Cancellation request has been accepted for further processing.")]
    Accepted = CorporateActionInstructionCancellationProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected for further processing due to system (data) reasons.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_bKPo49p-Ed-ak6NoX_4Aeg_1629502930")]
    [Description(@"Cancellation request has been rejected for further processing due to system (data) reasons.")]
    Rejected = CorporateActionInstructionCancellationProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
