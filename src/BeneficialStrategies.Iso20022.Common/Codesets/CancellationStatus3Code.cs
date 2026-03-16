// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0MgZdp-Ed-ak6NoX_4Aeg_1830748434")]
[Description(@"Specifies the cancellation status.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus3Code
{
    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_a0MgZtp-Ed-ak6NoX_4Aeg_1830748469")]
    [Description(
        @"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing."
    )]
    Accepted = CancellationStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_a0MgZ9p-Ed-ak6NoX_4Aeg_1830748470")]
    [Description(
        @"Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected."
    )]
    Pending = CancellationStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction / request has been accepted and processed, the cancellation is complete.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_a0MgaNp-Ed-ak6NoX_4Aeg_1830748494")]
    [Description(
        @"Cancellation instruction / request has been accepted and processed, the cancellation is complete."
    )]
    Complete = CancellationStatusCode.Complete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction / request has been received by issuer or registrar.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_a0Mgadp-Ed-ak6NoX_4Aeg_1830748512")]
    [Description(@"Cancellation instruction / request has been received by issuer or registrar.")]
    ReceivedByIssuerOrRegistrar = CancellationStatusCode.ReceivedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
}
