// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the result of an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_abTfSdp-Ed-ak6NoX_4Aeg_-698007078")]
[Description(@"Indicates the result of an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
public enum InvestigationExecutionConfirmation4Code
{
    /// <summary>
    /// Used when a requested cancellation has been partially executed.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_abdQQNp-Ed-ak6NoX_4Aeg_-698006802")]
    [Description(@"Used when a requested cancellation has been partially executed.")]
    PartiallyExecutedCancellationRequest = InvestigationExecutionConfirmationCode.PartiallyExecutedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_abdQQdp-Ed-ak6NoX_4Aeg_-698006801")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest = InvestigationExecutionConfirmationCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
}
