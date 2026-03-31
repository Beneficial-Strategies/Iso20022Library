// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the transaction or the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-bahwOBjEeiVRbNQx5-Vhg")]
[Description(@"Specifies the reason why the transaction or the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PendingReason17Code>))]
#endif
public enum PendingReason17Code
{
    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_Es9YUeBkEeiVRbNQx5-Vhg")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonCode.AwaitingConfirmation, // same ordinal as derivation source for type conversions
}
