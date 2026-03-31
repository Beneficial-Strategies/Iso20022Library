// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXW31tp-Ed-ak6NoX_4Aeg_349830100")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(PaymentStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancellationIndividualStatus1Code>))]
#endif
public enum CancellationIndividualStatus1Code
{
    /// <summary>
    /// Cancellation request is rejected
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_bXW319p-Ed-ak6NoX_4Aeg_349830132")]
    [Description(@"Cancellation request is rejected")]
    RejectedCancellationRequest = PaymentStatusCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_bXgo0Np-Ed-ak6NoX_4Aeg_349830162")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest = PaymentStatusCode.AcceptedCancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_bXgo0dp-Ed-ak6NoX_4Aeg_349830163")]
    [Description(@"Cancellation request is pending.")]
    PendingCancellationRequest = PaymentStatusCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
}
