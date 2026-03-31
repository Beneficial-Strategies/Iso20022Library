// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0yWQtp-Ed-ak6NoX_4Aeg_2105332425")]
[Description(@"Specifies the underlying reason for cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancelledStatusReason3Code>))]
#endif
public enum CancelledStatusReason3Code
{
    /// <summary>
    /// Transaction is cancelled by the transfer agent.
    /// Encoded/decoded by serializers as &quot;CNTA&quot;.
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_a0yWQ9p-Ed-ak6NoX_4Aeg_2105332427")]
    [Description(@"Transaction is cancelled by the transfer agent.")]
    CancelledByTransferAgent = CancelledStatusReasonCode.CancelledByTransferAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the client.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_a0yWRNp-Ed-ak6NoX_4Aeg_2105332450")]
    [Description(@"Transaction is cancelled by the client.")]
    CancelledByClient = CancelledStatusReasonCode.CancelledByClient, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the intermediary.
    /// Encoded/decoded by serializers as &quot;CNIN&quot;.
    /// </summary>
    [EnumMember(Value = "CNIN")]
    [IsoId("_a0yWRdp-Ed-ak6NoX_4Aeg_2105332467")]
    [Description(@"Transaction is cancelled by the intermediary.")]
    CancelledByIntermediary = CancelledStatusReasonCode.CancelledByIntermediary, // same ordinal as derivation source for type conversions
}
