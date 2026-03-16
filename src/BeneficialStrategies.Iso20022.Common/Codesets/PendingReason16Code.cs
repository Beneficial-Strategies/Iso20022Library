// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason why the instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b44F4LLJEemDyeh7tbvg1w")]
[Description(@"Specifies a reason why the instruction is pending.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum PendingReason16Code
{
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_kz3q8bLJEemDyeh7tbvg1w")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional documents requested missing.
    /// Encoded/decoded by serializers as &quot;ADDM&quot;.
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("_zPni0bLJEemDyeh7tbvg1w")]
    [Description(@"Additional documents requested missing.")]
    AdditionalDocumentationMissing = PendingFailingReasonV2Code.AdditionalDocumentationMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_3mRaAbLJEemDyeh7tbvg1w")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonV2Code.QuantityDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as &quot;DREM&quot;.
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("_C8coEbLKEemDyeh7tbvg1w")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed = PendingFailingReasonV2Code.DeadlineToRegisterMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_HJ4R0bLKEemDyeh7tbvg1w")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails = PendingFailingReasonV2Code.PendingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_YKdd8bLKEemDyeh7tbvg1w")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = PendingFailingReasonV2Code.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_lv5_8bLKEemDyeh7tbvg1w")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition = PendingFailingReasonV2Code.InsufficientThresholdPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_4W2s8bLKEemDyeh7tbvg1w")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV2Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_5tcFYbLKEemDyeh7tbvg1w")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as &quot;NPOS&quot;.
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("_F5UMYbLLEemDyeh7tbvg1w")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition = PendingFailingReasonV2Code.NoRegisteredPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid registration discrepancy.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_GqtNEbLLEemDyeh7tbvg1w")]
    [Description(@"Invalid registration discrepancy.")]
    RegistrationDiscrepancy = PendingFailingReasonV2Code.RegistrationDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_IgGBYbLLEemDyeh7tbvg1w")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Proxy Information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_ViIUUbLLEemDyeh7tbvg1w")]
    [Description(@"Invalid Proxy Information.")]
    ProxyCardDiscrepancy = PendingFailingReasonV2Code.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_XtFI8bLLEemDyeh7tbvg1w")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase or loan."
    )]
    PendingReceipt = PendingFailingReasonV2Code.PendingReceipt, // same ordinal as derivation source for type conversions
}
