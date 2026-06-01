// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0Bl8MKodEfCG2_q2WT-90w")]
[Description(@"Specifies the reason why a cancellation request sent for the related instruction is pending.")]
[DerivedFrom(typeof(PendingFailingReasonV4Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingReason35Code>))]
public enum PendingReason35Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_I0Gn8Sm5EfGfZ9PfK70MMg")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV4Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting cancellation of one of the party.
    /// Encoded/decoded by serializers as &quot;CDAC&quot;.
    /// </summary>
    [EnumMember(Value = "CDAC")]
    [IsoId("_I0Gn9ym5EfGfZ9PfK70MMg")]
    [Description(@"Awaiting cancellation of one of the party.")]
    ConditionalDeliveryAwaitingCancellation = PendingFailingReasonV4Code.ConditionalDeliveryAwaitingCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_I0Gn9Sm5EfGfZ9PfK70MMg")]
    [Description(
        @"Execution is conditional to the execution of a process linked to the currency of the transaction."
    )]
    ConditionalCurrency = PendingFailingReasonV4Code.ConditionalCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_I0Gn-Sm5EfGfZ9PfK70MMg")]
    [Description(
        @"Execution is conditional to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement = PendingFailingReasonV4Code.ConditionalRealignement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_I0Gn-ym5EfGfZ9PfK70MMg")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar = PendingFailingReasonV4Code.ConditionalRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_I0Gn8ym5EfGfZ9PfK70MMg")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonV4Code.AwaitingConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as &quot;INBC&quot;.
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("_I0Gn_Sm5EfGfZ9PfK70MMg")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount = PendingFailingReasonV4Code.IncompleteNumberCount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_I0Gn_ym5EfGfZ9PfK70MMg")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV4Code.Other, // same ordinal as derivation source for type conversions
}
