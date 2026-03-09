// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of the notification cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZgdAltp-Ed-ak6NoX_4Aeg_1782111527")]
[Description(@"Specifies the reason of a rejection of the notification cancellation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason11Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZgdAl9p-Ed-ak6NoX_4Aeg_-698385107")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_ZgdAmNp-Ed-ak6NoX_4Aeg_-698385076")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonCode.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_ZgdAmdp-Ed-ak6NoX_4Aeg_-698385045")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress = RejectionReasonCode.RejectedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;REFI&quot;.
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_ZgmKgNp-Ed-ak6NoX_4Aeg_-698385015")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification = RejectionReasonCode.InvalidCAIdentification, // same ordinal as derivation source for type conversions
    
}
