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
[IsoId("_Iuy9YLMZEfCEXew4g5B5oA")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV4Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingReason38Code>))]
public enum PendingReason38Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("6260988c-6eed-4b9e-9599-413991bd52cc")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV4Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as &quot;BSTR&quot;.
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("c142d809-44bb-43a7-a630-68aecb01f86e")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod = PendingFailingReasonV4Code.BeforeInstructionPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("a644134e-8b71-4205-8aa5-25a325d54b6f")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonV4Code.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as &quot;DQCS&quot;.
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("8bf454c3-a169-4b2b-b5ea-6a8dde633fc6")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    DisagreementOnCashAmount = PendingFailingReasonV4Code.DisagreementOnCashAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("e0236e41-df44-47d8-b0ad-f79cb68a81b1")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonV4Code.QuantityDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("863cbd4f-0205-492d-a092-9bba68675643")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails = PendingFailingReasonV4Code.PendingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required paperwork is invalid, incomplete or missing.
    /// Encoded/decoded by serializers as &quot;IPAW&quot;.
    /// </summary>
    [EnumMember(Value = "IPAW")]
    [IsoId("327eef08-a523-4d8e-8462-05a432da568d")]
    [Description(@"Required paperwork is invalid, incomplete or missing.")]
    InvalidPaperwork = PendingFailingReasonV4Code.InvalidPaperwork, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received prior to entitlement date.
    /// Encoded/decoded by serializers as &quot;IPED&quot;.
    /// </summary>
    [EnumMember(Value = "IPED")]
    [IsoId("3b9ce602-75e8-429d-b404-ba901f84b56d")]
    [Description(@"Instruction was received prior to entitlement date.")]
    InstructionPriorToEntitlementDate = PendingFailingReasonV4Code.InstructionPriorToEntitlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as &quot;ITAX&quot;.
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("c75954a9-80de-438c-b590-29352649ea24")]
    [Description(
        @"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country."
    )]
    IncorrectTaxRate = PendingFailingReasonV4Code.IncorrectTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("794696d3-3592-4f08-8079-538912373ea5")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV4Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("246f3bc4-ecc1-473b-8785-1422508b5fb7")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV4Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("093f221a-9784-4a13-b95c-0481908bb4af")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification = PendingFailingReasonV4Code.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("53d8540e-71d9-476c-a50c-88f16dc41a13")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV4Code.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("5877a6c3-9b62-4e87-a428-40a2553e3810")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate = PendingFailingReasonV4Code.MissingTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("b8544b61-7fc3-427d-a5ac-47fb5a3900a4")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate = PendingFailingReasonV4Code.InconsistentTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("3abcae19-2222-4fc5-8038-913f89ccc04c")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV4Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("61cf4999-a932-46a8-a087-7ba26becd6ee")]
    [Description(
        @"Instruction is pending receipt of securities, for example, from a purchase or loan."
    )]
    PendingReceipt = PendingFailingReasonV4Code.PendingReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System is not available. Instruction is sent outside of business hours.
    /// Encoded/decoded by serializers as &quot;SNAV&quot;.
    /// </summary>
    [EnumMember(Value = "SNAV")]
    [IsoId("9bfcaac0-4bb3-4673-a2e3-752c2bb0f058")]
    [Description(@"System is not available. Instruction is sent outside of business hours.")]
    SystemNotAvailable = PendingFailingReasonV4Code.SystemNotAvailable, // same ordinal as derivation source for type conversions
}
