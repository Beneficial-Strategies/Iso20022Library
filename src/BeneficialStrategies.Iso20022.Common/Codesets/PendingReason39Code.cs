// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2TaxwLMZEfCEXew4g5B5oA")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV4Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingReason39Code>))]
public enum PendingReason39Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("bf74c5b0-e5ab-4bb3-a465-815eb082a9db")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV4Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("791d32d3-c70c-4dc3-aa0b-4fe6fa455ebd")]
    [Description(
        @"Counterparty's instruction and your instruction are on hold/frozen/ in a preadvice mode."
    )]
    BothInstructionsOnHold = PendingFailingReasonV4Code.BothInstructionsOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("4d7bf533-714b-4506-9bcf-03fbf04c0bea")]
    [Description(
        @"Insufficient deliverable financial instruments in counterparty's account or counterparty does not hold financial instruments."
    )]
    CounterpartyInsufficientSecurities = PendingFailingReasonV4Code.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in counterparty's account.
    /// Encoded/decoded by serializers as &quot;CMON&quot;.
    /// </summary>
    [EnumMember(Value = "CMON")]
    [IsoId("bc322686-3b2b-4ffe-9957-b8e487ffa6ef")]
    [Description(@"Insufficient money in counterparty's account.")]
    CounterpartyInsufficientMoney = PendingFailingReasonV4Code.CounterpartyInsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle.
    /// Encoded/decoded by serializers as &quot;CYCL&quot;.
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("0343659f-7a67-4bf1-ace2-014febd6f2fa")]
    [Description(
        @"Your instruction is confirmed in the local market or is ready for settlement, awaiting next settlement cycle."
    )]
    AwaitingNextSettlementCycle = PendingFailingReasonV4Code.AwaitingNextSettlementCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting settlement date. No settlement problems to be reported.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("1d6fda34-dc82-408b-981d-2f88af78b8d2")]
    [Description(@"Awaiting settlement date. No settlement problems to be reported.")]
    AwaitingSettlementDate = PendingFailingReasonV4Code.AwaitingSettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("5c6304fc-5359-4778-a071-a33a5dc32341")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV4Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("ca3e1ca7-003f-4e10-86f6-7d4b070cfb9f")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV4Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("98fcfd09-f90f-42ea-86a6-a319ecf1d24f")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction = PendingFailingReasonV4Code.PendingLinkedInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("826761a0-1a42-4ed3-b841-0669904bd76d")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV4Code.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("e25e2cf5-f842-47f5-b390-48c6b59a12af")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV4Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty's instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PRCY&quot;.
    /// </summary>
    [EnumMember(Value = "PRCY")]
    [IsoId("950fb58a-9f9d-4a5f-92ad-8bdaf0424baf")]
    [Description(@"Counterparty's instruction is a preadvice, that is, for matching only.")]
    CounterpartyInstructionOnHold = PendingFailingReasonV4Code.CounterpartyInstructionOnHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is a preadvice, that is, for matching only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("5cb5b25a-a729-41ee-bdcc-60fb1faac685")]
    [Description(@"Your instruction is a preadvice, that is, for matching only.")]
    YourInstructionOnHold = PendingFailingReasonV4Code.YourInstructionOnHold, // same ordinal as derivation source for type conversions
}
