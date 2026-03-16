// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of service selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_urguca5EEeWCgYcWSNgX5g")]
[Description(@"Describes the type of service selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType10Code
{
    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as &quot;TRFC&quot;.
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_u4LRca5EEeWCgYcWSNgX5g")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer = ATMServiceTypeCode.CustomerTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as &quot;TRFI&quot;.
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_u4LRc65EEeWCgYcWSNgX5g")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer = ATMServiceTypeCode.InterCustomerTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_u4LRda5EEeWCgYcWSNgX5g")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment = ATMServiceTypeCode.Payment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask for account statement information to a related custumer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_0YbN8a5EEeWCgYcWSNgX5g")]
    [Description(@"Ask for account statement information to a related custumer account.")]
    AccountStatements = ATMServiceTypeCode.AccountStatements, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_0ifI465EEeWCgYcWSNgX5g")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry = ATMServiceTypeCode.BalanceInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification of the card.
    /// Encoded/decoded by serializers as &quot;CDVF&quot;.
    /// </summary>
    [EnumMember(Value = "CDVF")]
    [IsoId("_0rR4g65EEeWCgYcWSNgX5g")]
    [Description(@"Verification of the card.")]
    CardVerification = ATMServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_002rQ65EEeWCgYcWSNgX5g")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal = ATMServiceTypeCode.ChosenWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask for customer profile with eventualy related account information.
    /// Encoded/decoded by serializers as &quot;CMPF&quot;.
    /// </summary>
    [EnumMember(Value = "CMPF")]
    [IsoId("_180Y465EEeWCgYcWSNgX5g")]
    [Description(@"Ask for customer profile with eventualy related account information.")]
    CustomerProfile = ATMServiceTypeCode.CustomerProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask to a DCC service provider to qualify the currency conversion for the card.
    /// Encoded/decoded by serializers as &quot;DCCS&quot;.
    /// </summary>
    [EnumMember(Value = "DCCS")]
    [IsoId("_3hpos65EEeWCgYcWSNgX5g")]
    [Description(@"Ask to a DCC service provider to qualify the currency conversion for the card.")]
    DynamicCurrencyConversion = ATMServiceTypeCode.DynamicCurrencyConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask for exchange rate for the ongoing deposit transaction.
    /// Encoded/decoded by serializers as &quot;XRTD&quot;.
    /// </summary>
    [EnumMember(Value = "XRTD")]
    [IsoId("_3plcs65EEeWCgYcWSNgX5g")]
    [Description(@"Ask for exchange rate for the ongoing deposit transaction.")]
    ExchangeRateDeposit = ATMServiceTypeCode.ExchangeRateDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask for exchange rate for the ongoing withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;XRTW&quot;.
    /// </summary>
    [EnumMember(Value = "XRTW")]
    [IsoId("_3wSho65EEeWCgYcWSNgX5g")]
    [Description(@"Ask for exchange rate for the ongoing withdrawal transaction.")]
    ExchangeRateWithdrawal = ATMServiceTypeCode.ExchangeRateWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_4GOVY65EEeWCgYcWSNgX5g")]
    [Description(@"Making change between media types.")]
    MakingChange = ATMServiceTypeCode.MakingChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as &quot;DPSN&quot;.
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_4NO8U65EEeWCgYcWSNgX5g")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit = ATMServiceTypeCode.NonVerifiedDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_5ak5M65EEeWCgYcWSNgX5g")]
    [Description(@"Modification of the card PIN value.")]
    PINChange = ATMServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_5g1SM65EEeWCgYcWSNgX5g")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery = ATMServiceTypeCode.PINRecovery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_5peQ065EEeWCgYcWSNgX5g")]
    [Description(@"Unblock the PIN.")]
    PINUnblock = ATMServiceTypeCode.PINUnblock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_54Etg65EEeWCgYcWSNgX5g")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message."
    )]
    PreAuthorisedWithdrawal = ATMServiceTypeCode.PreAuthorisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_68Cr865EEeWCgYcWSNgX5g")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal = ATMServiceTypeCode.ProfileWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Select the EMV applications allowed by the acquirer.
    /// Encoded/decoded by serializers as &quot;EMVS&quot;.
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_7Etfw65EEeWCgYcWSNgX5g")]
    [Description(@"Select the EMV applications allowed by the acquirer.")]
    SelectEMVApplication = ATMServiceTypeCode.SelectEMVApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_7WS_A65EEeWCgYcWSNgX5g")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal = ATMServiceTypeCode.StandardWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_7b0YM65EEeWCgYcWSNgX5g")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal = ATMServiceTypeCode.SupervisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_7hoFQ65EEeWCgYcWSNgX5g")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit = ATMServiceTypeCode.VerifiedDeposit, // same ordinal as derivation source for type conversions
}
