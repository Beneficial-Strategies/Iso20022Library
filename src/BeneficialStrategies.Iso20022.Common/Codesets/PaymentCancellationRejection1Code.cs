// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Returned when a request for cancellation cannot be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zb9ZoA93EeGeV5vP7Mvdig_-151965379")]
[Description(@"Returned when a request for cancellation cannot be executed.")]
[DerivedFrom(typeof(PaymentCancellationRejectionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentCancellationRejection1Code>))]
#endif
public enum PaymentCancellationRejection1Code
{
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_zb9ZoQ93EeGeV5vP7Mvdig_323838395")]
    [Description(@"Reported when the cancellation cannot be accepted because of regulatory rules.")]
    LegalDecision = PaymentCancellationRejectionCode.LegalDecision, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported when the cancellation cannot be accepted because of an agent refuses to cancel.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_zb9Zog93EeGeV5vP7Mvdig_-596999348")]
    [Description(
        @"Reported when the cancellation cannot be accepted because of an agent refuses to cancel."
    )]
    AgentDecision = PaymentCancellationRejectionCode.AgentDecision, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported when the cancellation cannot be accepted because of a customer decision (Creditor).
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_zb9Zow93EeGeV5vP7Mvdig_749712831")]
    [Description(
        @"Reported when the cancellation cannot be accepted because of a customer decision (Creditor)."
    )]
    CustomerDecision = PaymentCancellationRejectionCode.CustomerDecision, // same ordinal as derivation source for type conversions
}
