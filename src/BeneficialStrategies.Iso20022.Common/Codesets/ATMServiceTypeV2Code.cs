// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of transaction available for a customer on an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMServiceTypeV2Code")]
[Description(@"Describes the type of transaction available for a customer on an ATM.")]
public enum ATMServiceTypeV2Code
{
    /// <summary>
    /// Download accounts associated to the customer card.
    /// Encoded/decoded by serializers as &quot;ACCD&quot;.
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_ATMServiceTypeV2Code_AccountDownload")]
    [Description(@"Download accounts associated to the customer card.")]
    AccountDownload,

    /// <summary>
    /// Request a full statement (that is a legal statement) related to a customer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_ATMServiceTypeV2Code_AccountStatements")]
    [Description(@"Request a full statement (that is a legal statement) related to a customer account.")]
    AccountStatements,

    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_ATMServiceTypeV2Code_BalanceInquiry")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry,

    /// <summary>
    /// Verification of the card.
    /// Encoded/decoded by serializers as &quot;CDVF&quot;.
    /// </summary>
    [EnumMember(Value = "CDVF")]
    [IsoId("_ATMServiceTypeV2Code_CardVerification")]
    [Description(@"Verification of the card.")]
    CardVerification,

    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_ATMServiceTypeV2Code_ChosenWithdrawal")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal,

    /// <summary>
    /// Ask for customer profile with eventualy related account information.
    /// Encoded/decoded by serializers as &quot;CMPF&quot;.
    /// </summary>
    [EnumMember(Value = "CMPF")]
    [IsoId("_ATMServiceTypeV2Code_CustomerProfile")]
    [Description(@"Ask for customer profile with eventualy related account information.")]
    CustomerProfile,

    /// <summary>
    /// Ask to a DCC service provider to qualify the currency conversion for the card.
    /// Encoded/decoded by serializers as &quot;DCCS&quot;.
    /// </summary>
    [EnumMember(Value = "DCCS")]
    [IsoId("_ATMServiceTypeV2Code_DynamicCurrencyConversion")]
    [Description(@"Ask to a DCC service provider to qualify the currency conversion for the card.")]
    DynamicCurrencyConversion,

    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as &quot;DPSN&quot;.
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_ATMServiceTypeV2Code_NonVerifiedDeposit")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit,

    /// <summary>
    /// Deposit of items.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_ATMServiceTypeV2Code_Deposit")]
    [Description(@"Deposit of items.")]
    Deposit,

    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_ATMServiceTypeV2Code_VerifiedDeposit")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit,

    /// <summary>
    /// Select the EMV applications allowed by the acquirer.
    /// Encoded/decoded by serializers as &quot;EMVS&quot;.
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_ATMServiceTypeV2Code_SelectEMVApplication")]
    [Description(@"Select the EMV applications allowed by the acquirer.")]
    SelectEMVApplication,

    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_ATMServiceTypeV2Code_MakingChange")]
    [Description(@"Making change between media types.")]
    MakingChange,

    /// <summary>
    /// Request a mini-statement (i.e. partial statement) related to a customer account.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_ATMServiceTypeV2Code_MiniStatement")]
    [Description(@"Request a mini-statement (i.e. partial statement) related to a customer account.")]
    MiniStatement,

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_ATMServiceTypeV2Code_PreAuthorisedWithdrawal")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.")]
    PreAuthorisedWithdrawal,

    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_ATMServiceTypeV2Code_PINChange")]
    [Description(@"Modification of the card PIN value.")]
    PINChange,

    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_ATMServiceTypeV2Code_PINRecovery")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery,

    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_ATMServiceTypeV2Code_PINUnblock")]
    [Description(@"Unblock the PIN.")]
    PINUnblock,

    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_ATMServiceTypeV2Code_ProfileWithdrawal")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal,

    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_ATMServiceTypeV2Code_SupervisedWithdrawal")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal,

    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_ATMServiceTypeV2Code_StandardWithdrawal")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal,

    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as &quot;TRFC&quot;.
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_ATMServiceTypeV2Code_CustomerTransfer")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer,

    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as &quot;TRFI&quot;.
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_ATMServiceTypeV2Code_InterCustomerTransfer")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer,

    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_ATMServiceTypeV2Code_Payment")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment,

    /// <summary>
    /// Ask for exchange rate for the ongoing deposit transaction.
    /// Encoded/decoded by serializers as &quot;XRTD&quot;.
    /// </summary>
    [EnumMember(Value = "XRTD")]
    [IsoId("_ATMServiceTypeV2Code_ExchangeRateDeposit")]
    [Description(@"Ask for exchange rate for the ongoing deposit transaction.")]
    ExchangeRateDeposit,

    /// <summary>
    /// Ask for exchange rate for the ongoing withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;XRTW&quot;.
    /// </summary>
    [EnumMember(Value = "XRTW")]
    [IsoId("_ATMServiceTypeV2Code_ExchangeRateWithdrawal")]
    [Description(@"Ask for exchange rate for the ongoing withdrawal transaction.")]
    ExchangeRateWithdrawal,

}
