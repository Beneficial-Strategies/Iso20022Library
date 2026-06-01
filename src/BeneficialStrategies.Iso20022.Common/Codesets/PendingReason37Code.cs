// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3VDxwLMVEfCEXew4g5B5oA")]
[Description(
    @"Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing."
)]
[DerivedFrom(typeof(PendingFailingReasonV4Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingReason37Code>))]
public enum PendingReason37Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_6H668bMVEfCEXew4g5B5oA")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV4Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as &quot;BSTR&quot;.
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("_87Dw8bMVEfCEXew4g5B5oA")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod = PendingFailingReasonV4Code.BeforeInstructionPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty disagreement on the chosen corporate action outturn.
    /// Encoded/decoded by serializers as &quot;BUMM&quot;.
    /// </summary>
    [EnumMember(Value = "BUMM")]
    [IsoId("_9C43QbMVEfCEXew4g5B5oA")]
    [Description(@"Counterparty disagreement on the chosen corporate action outturn.")]
    BuyerProtectionMismatch = PendingFailingReasonV4Code.BuyerProtectionMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_NRz88bMWEfCEXew4g5B5oA")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonV4Code.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as &quot;DQCS&quot;.
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_AnsawbMWEfCEXew4g5B5oA")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    DisagreementOnCashAmount = PendingFailingReasonV4Code.DisagreementOnCashAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_L1V-8bMWEfCEXew4g5B5oA")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonV4Code.QuantityDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the election to counterparty response deadline.
    /// Encoded/decoded by serializers as &quot;ECRD&quot;.
    /// </summary>
    [EnumMember(Value = "ECRD")]
    [IsoId("_AxXUIbMWEfCEXew4g5B5oA")]
    [Description(@"Received after the election to counterparty response deadline.")]
    ElectionToCounterpartyResponseDeadlineMissed = PendingFailingReasonV4Code.ElectionToCounterpartyResponseDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_KPmJIbMWEfCEXew4g5B5oA")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails = PendingFailingReasonV4Code.PendingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required paperwork is invalid, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;IPAW&quot;.
    /// </summary>
    [EnumMember(Value = "IPAW")]
    [IsoId("_FSpG8bMWEfCEXew4g5B5oA")]
    [Description(@"Required paperwork is invalid, incomplete or missing.")]
    InvalidPaperwork = PendingFailingReasonV4Code.InvalidPaperwork, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received prior to entitlement date.
    /// Encoded/decoded by serializers as &quot;IPED&quot;.
    /// </summary>
    [EnumMember(Value = "IPED")]
    [IsoId("_DS_jYbMWEfCEXew4g5B5oA")]
    [Description(@"Instruction was received prior to entitlement date.")]
    InstructionPriorToEntitlementDate = PendingFailingReasonV4Code.InstructionPriorToEntitlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as &quot;ITAX&quot;.
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("_DNbt8bMWEfCEXew4g5B5oA")]
    [Description(
        @"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country."
    )]
    IncorrectTaxRate = PendingFailingReasonV4Code.IncorrectTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_FXdVgbMWEfCEXew4g5B5oA")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV4Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_HCIuobMWEfCEXew4g5B5oA")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV4Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_HKD7kbMWEfCEXew4g5B5oA")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification = PendingFailingReasonV4Code.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_FIXJkbMWEfCEXew4g5B5oA")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV4Code.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_Ijw5cbMWEfCEXew4g5B5oA")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate = PendingFailingReasonV4Code.MissingTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_DIQTAbMWEfCEXew4g5B5oA")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate = PendingFailingReasonV4Code.InconsistentTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_I3GFIbMWEfCEXew4g5B5oA")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV4Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_KVYBAbMWEfCEXew4g5B5oA")]
    [Description(
        @"Instruction is pending receipt of securities, for example, from a purchase or loan."
    )]
    PendingReceipt = PendingFailingReasonV4Code.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System is not available. Instruction is sent outside of business hours.
    /// Encoded/decoded by serializers as &quot;SNAV&quot;.
    /// </summary>
    [EnumMember(Value = "SNAV")]
    [IsoId("_MOhT8bMWEfCEXew4g5B5oA")]
    [Description(@"System is not available. Instruction is sent outside of business hours.")]
    SystemNotAvailable = PendingFailingReasonV4Code.SystemNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allegement has been sent out to counterparty. Waiting for their response.
    /// Encoded/decoded by serializers as &quot;WCTF&quot;.
    /// </summary>
    [EnumMember(Value = "WCTF")]
    [IsoId("_7ijs8bMVEfCEXew4g5B5oA")]
    [Description(@"Allegement has been sent out to counterparty. Waiting for their response.")]
    AwaitingCounterpartyResponse = PendingFailingReasonV4Code.AwaitingCounterpartyResponse, // same ordinal as derivation source for type conversions
}
