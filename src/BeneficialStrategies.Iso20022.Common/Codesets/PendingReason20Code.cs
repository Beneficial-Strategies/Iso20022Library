// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3uReYe6JEeqc-LCjwLsUVg")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
public enum PendingReason20Code
{
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_4HaXIe6JEeqc-LCjwLsUVg")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = PendingFailingReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_4HaXI-6JEeqc-LCjwLsUVg")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending receipt of beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_4HaXJe6JEeqc-LCjwLsUVg")]
    [Description(@"Pending receipt of beneficiary owner details.")]
    PendingBeneficiaryOwnerDetails = PendingFailingReasonV2Code.PendingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_4HaXJ-6JEeqc-LCjwLsUVg")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification = PendingFailingReasonV2Code.MissingCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_4HaXKe6JEeqc-LCjwLsUVg")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV2Code.InsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_4HaXK-6JEeqc-LCjwLsUVg")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV2Code.LackOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_4HaXLe6JEeqc-LCjwLsUVg")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_4HaXL-6JEeqc-LCjwLsUVg")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonV2Code.QuantityDisagreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase or loan.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_4HaXMe6JEeqc-LCjwLsUVg")]
    [Description(@"The instruction is pending receipt of securities, for example, from a purchase or loan.")]
    PendingReceipt = PendingFailingReasonV2Code.PendingReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_4HaXM-6JEeqc-LCjwLsUVg")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonV2Code.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed cash amount.
    /// Encoded/decoded by serializers as &quot;DQCS&quot;.
    /// </summary>
    [EnumMember(Value = "DQCS")]
    [IsoId("_4HaXNe6JEeqc-LCjwLsUVg")]
    [Description(@"Unrecognised or invalid instructed cash amount.")]
    DisagreementOnCashAmount = PendingFailingReasonV2Code.DisagreementOnCashAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.
    /// Encoded/decoded by serializers as &quot;ITAX&quot;.
    /// </summary>
    [EnumMember(Value = "ITAX")]
    [IsoId("_4HaXN-6JEeqc-LCjwLsUVg")]
    [Description(@"Tax rate provided is incorrect. It falls outside the acceptable values for that investment country.")]
    IncorrectTaxRate = PendingFailingReasonV2Code.IncorrectTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax rate is not consistent with the documentation in place.
    /// Encoded/decoded by serializers as &quot;NTAX&quot;.
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_4HaXOe6JEeqc-LCjwLsUVg")]
    [Description(@"Tax rate is not consistent with the documentation in place.")]
    InconsistentTaxRate = PendingFailingReasonV2Code.InconsistentTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax rate is missing.
    /// Encoded/decoded by serializers as &quot;MTAX&quot;.
    /// </summary>
    [EnumMember(Value = "MTAX")]
    [IsoId("_4HaXO-6JEeqc-LCjwLsUVg")]
    [Description(@"Tax rate is missing.")]
    MissingTaxRate = PendingFailingReasonV2Code.MissingTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System is not available. Instruction is sent outside of business hours.
    /// Encoded/decoded by serializers as &quot;SNAV&quot;.
    /// </summary>
    [EnumMember(Value = "SNAV")]
    [IsoId("_-P4KMe6JEeqc-LCjwLsUVg")]
    [Description(@"System is not available. Instruction is sent outside of business hours.")]
    SystemNotAvailable = PendingFailingReasonV2Code.SystemNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is submitted before instruction start date.
    /// Encoded/decoded by serializers as &quot;BSTR&quot;.
    /// </summary>
    [EnumMember(Value = "BSTR")]
    [IsoId("__qxa4e6JEeqc-LCjwLsUVg")]
    [Description(@"Instruction is submitted before instruction start date.")]
    BeforeInstructionPeriod = PendingFailingReasonV2Code.BeforeInstructionPeriod, // same ordinal as derivation source for type conversions
    
}
