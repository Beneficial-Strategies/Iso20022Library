// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sWTVoWIIEe6Vre0WuwPTOg")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum PendingReason27Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as &quot;BSTR&quot;.
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod = PendingFailingReasonV2Code.BeforeInstructionPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonV2Code.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as &quot;DQCS&quot;.
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    DisagreementOnCashAmount = PendingFailingReasonV2Code.DisagreementOnCashAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonV2Code.QuantityDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails = PendingFailingReasonV2Code.PendingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required paperwork is invalid, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;IPAW&quot;.
    /// </summary>
    [EnumMember(Value = "IPAW")]
    [IsoId("")]
    [Description(@"Required paperwork is invalid, incomplete or missing.")]
    InvalidPaperwork = PendingFailingReasonV2Code.InvalidPaperwork, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received prior to entitlement date.
    /// Encoded/decoded by serializers as &quot;IPED&quot;.
    /// </summary>
    [EnumMember(Value = "IPED")]
    [IsoId("")]
    [Description(@"Instruction was received prior to entitlement date.")]
    InstructionPriorToEntitlementDate =
        PendingFailingReasonV2Code.InstructionPriorToEntitlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as &quot;ITAX&quot;.
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("")]
    [Description(
        @"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country."
    )]
    IncorrectTaxRate = PendingFailingReasonV2Code.IncorrectTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV2Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification = PendingFailingReasonV2Code.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV2Code.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate = PendingFailingReasonV2Code.MissingTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate = PendingFailingReasonV2Code.InconsistentTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("")]
    [Description(
        @"The instruction is pending receipt of securities, for example, from a purchase or loan."
    )]
    PendingReceipt = PendingFailingReasonV2Code.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System is not available. Instruction is sent outside of business hours.
    /// Encoded/decoded by serializers as &quot;SNAV&quot;.
    /// </summary>
    [EnumMember(Value = "SNAV")]
    [IsoId("")]
    [Description(@"System is not available. Instruction is sent outside of business hours.")]
    SystemNotAvailable = PendingFailingReasonV2Code.SystemNotAvailable, // same ordinal as derivation source for type conversions
}
