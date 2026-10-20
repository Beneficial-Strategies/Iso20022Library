// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason why the instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pME6ULMUEfCEXew4g5B5oA")]
[Description(@"Specifies a reason why the instruction is pending.")]
[DerivedFrom(typeof(PendingFailingReasonV4Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingReason41Code>))]
public enum PendingReason41Code
{
    /// <summary>
    /// Additional documents requested missing.
    /// Encoded/decoded by serializers as &quot;ADDM&quot;.
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("d69aafda-2bae-41e9-9217-c7cdce5c364e")]
    [Description(@"Additional documents requested missing.")]
    AdditionalDocumentationMissing = PendingFailingReasonV4Code.AdditionalDocumentationMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("eace5e1d-e16b-4604-80f5-56726a75cadc")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV4Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("f01d8be8-c3f3-4c99-b15d-e5e87d12b4e8")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonV4Code.QuantityDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as &quot;DREM&quot;.
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("ee875bd5-680a-485a-ac2d-9fd9b8681174")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed = PendingFailingReasonV4Code.DeadlineToRegisterMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("dcdc8ed5-3b06-45e6-8acb-4d32b34ed376")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails = PendingFailingReasonV4Code.PendingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received prior to entitlement date.
    /// Encoded/decoded by serializers as &quot;IPED&quot;.
    /// </summary>
    [EnumMember(Value = "IPED")]
    [IsoId("81223344-abd7-4987-acca-3ae65acf3829")]
    [Description(@"Instruction was received prior to entitlement date.")]
    InstructionPriorToEntitlementDate = PendingFailingReasonV4Code.InstructionPriorToEntitlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("3360c645-736a-40bd-a64d-c25a13628c4d")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = PendingFailingReasonV4Code.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("cd984b28-8410-4569-9714-1d5cdaceeffb")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition = PendingFailingReasonV4Code.InsufficientThresholdPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid registration discrepancy.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("482cbfb5-4c36-40e2-bfa7-eb9444935c8d")]
    [Description(@"Invalid registration discrepancy.")]
    RegistrationDiscrepancy = PendingFailingReasonV4Code.RegistrationDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("1b467426-c6fa-4648-8d28-42e05b3d51d8")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV4Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("1cc1825e-5652-4ea2-a9fa-a6bc89cb64a5")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV4Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as &quot;NPOS&quot;.
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("6926d7ef-b722-4dc9-af3c-d80f398b62e0")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition = PendingFailingReasonV4Code.NoRegisteredPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("31801b89-e664-4cb3-aa9a-746034b4f055")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV4Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("e25beab7-fe37-4d89-a7f5-8ea270b80be8")]
    [Description(
        @"Instruction is pending receipt of securities, for example, from a purchase or loan."
    )]
    PendingReceipt = PendingFailingReasonV4Code.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Proxy Information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("44ac464c-d5bb-42a2-b9e4-049384f1faa2")]
    [Description(@"Invalid Proxy Information.")]
    ProxyCardDiscrepancy = PendingFailingReasonV4Code.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions
}
