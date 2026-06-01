// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the cancellation request has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TqgRcLMjEfC4pMi0W1Gykw")]
[Description(@"Specifies the reason why the cancellation request has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV4Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingCancellationReason10Code>))]
public enum PendingCancellationReason10Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("90a618ef-e83a-4465-9add-90131c41fa90")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV4Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("b43355ea-3cc5-4b40-8e9a-962d0e039972")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonV4Code.AwaitingConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("d9a7d1a8-e87d-498f-844e-20be3f4301da")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV4Code.Other, // same ordinal as derivation source for type conversions
}
