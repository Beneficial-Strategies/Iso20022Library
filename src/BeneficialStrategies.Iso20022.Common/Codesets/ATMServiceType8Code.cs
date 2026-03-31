// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service to be offered for a customer at an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_82-oEa4XEeW_TaP-ygI0SQ")]
[Description(@"Type of service to be offered for a customer at an ATM.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMServiceType8Code>))]
#endif
public enum ATMServiceType8Code
{
    /// <summary>
    /// Ask for account statement information to a related custumer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_9CAMUa4XEeW_TaP-ygI0SQ")]
    [Description(@"Ask for account statement information to a related custumer account.")]
    AccountStatements = ATMServiceTypeCode.AccountStatements, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_9CAMU64XEeW_TaP-ygI0SQ")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry = ATMServiceTypeCode.BalanceInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_9CAMV64XEeW_TaP-ygI0SQ")]
    [Description(@"Modification of the card PIN value.")]
    PINChange = ATMServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_9CAMWa4XEeW_TaP-ygI0SQ")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal = ATMServiceTypeCode.StandardWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_9CAMW64XEeW_TaP-ygI0SQ")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal = ATMServiceTypeCode.ProfileWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_9CAMXa4XEeW_TaP-ygI0SQ")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message."
    )]
    PreAuthorisedWithdrawal = ATMServiceTypeCode.PreAuthorisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_9CAMX64XEeW_TaP-ygI0SQ")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal = ATMServiceTypeCode.ChosenWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as &quot;TRFC&quot;.
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_C8vsca4YEeW_TaP-ygI0SQ")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer = ATMServiceTypeCode.CustomerTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as &quot;TRFI&quot;.
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_K6p-Ma4YEeW_TaP-ygI0SQ")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer = ATMServiceTypeCode.InterCustomerTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_L2IvAa4YEeW_TaP-ygI0SQ")]
    [Description(@"Making change between media types.")]
    MakingChange = ATMServiceTypeCode.MakingChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as &quot;DPSN&quot;.
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_L-QJMa4YEeW_TaP-ygI0SQ")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit = ATMServiceTypeCode.NonVerifiedDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_NUGh0a4YEeW_TaP-ygI0SQ")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery = ATMServiceTypeCode.PINRecovery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_NbjNoa4YEeW_TaP-ygI0SQ")]
    [Description(@"Unblock the PIN.")]
    PINUnblock = ATMServiceTypeCode.PINUnblock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_PGo2ca4YEeW_TaP-ygI0SQ")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal = ATMServiceTypeCode.SupervisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_PPkwAa4YEeW_TaP-ygI0SQ")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit = ATMServiceTypeCode.VerifiedDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_IAJp4a-iEeWJvLRJ8PsD_w")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment = ATMServiceTypeCode.Payment, // same ordinal as derivation source for type conversions
}
