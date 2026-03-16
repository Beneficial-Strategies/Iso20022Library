// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q7yCAbLQEemDyeh7tbvg1w")]
[Description(@"Specifies the cancellation status.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus6Code
{
    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_RaR74bLQEemDyeh7tbvg1w")]
    [Description(
        @"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing."
    )]
    Accepted = CancellationStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction / request has been accepted and processed, the cancellation is complete.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_RaR75bLQEemDyeh7tbvg1w")]
    [Description(
        @"Cancellation instruction / request has been accepted and processed, the cancellation is complete."
    )]
    Complete = CancellationStatusCode.Complete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction / request has been received by issuer or registrar.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_RaR757LQEemDyeh7tbvg1w")]
    [Description(@"Cancellation instruction / request has been received by issuer or registrar.")]
    ReceivedByIssuerOrRegistrar = CancellationStatusCode.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
}
