// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the cancellation of the disclosure request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IZJRIEV4EemRx7jyevcLwg")]
[Description(@"Specifies the reason for the cancellation of the disclosure request.")]
[Derivations(typeof(DisclosureRequestCancellationReason1Code))]
public enum DisclosureRequestCancellationReasonCode
{
    /// <summary>
    /// The cancellation of the disclosure request is due to a processsing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_ZKixwEV4EemRx7jyevcLwg")]
    [Description(@"The cancellation of the disclosure request is due to a processsing error.")]
    Processing,

    /// <summary>
    /// The cancellation of the discolure request is due to the withdrawal of the request  by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_30joAEV4EemRx7jyevcLwg")]
    [Description(
        @"The cancellation of the discolure request is due to the withdrawal of the request  by the issuer."
    )]
    Withdrawal,
}
