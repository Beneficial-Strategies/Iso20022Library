// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of inquiry selected by the customer or the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMServiceType12Code")]
[Description(@"Describes the type of inquiry selected by the customer or the ATM.")]
[DerivedFrom(typeof(ATMServiceTypeV2Code))]
public enum ATMServiceType12Code
{
    /// <summary>
    /// Download accounts associated to the customer card.
    /// Encoded/decoded by serializers as &quot;ACCD&quot;.
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_ATMServiceType12Code_AccountDownload")]
    [Description(@"Download accounts associated to the customer card.")]
    AccountDownload = ATMServiceTypeV2Code.AccountDownload,

    /// <summary>
    /// Request a full statement (that is a legal statement) related to a customer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_ATMServiceType12Code_AccountStatements")]
    [Description(
        @"Request a full statement (that is a legal statement) related to a customer account."
    )]
    AccountStatements = ATMServiceTypeV2Code.AccountStatements,

    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_ATMServiceType12Code_BalanceInquiry")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry = ATMServiceTypeV2Code.BalanceInquiry,

    /// <summary>
    /// Verification of the card.
    /// Encoded/decoded by serializers as &quot;CDVF&quot;.
    /// </summary>
    [EnumMember(Value = "CDVF")]
    [IsoId("_ATMServiceType12Code_CardVerification")]
    [Description(@"Verification of the card.")]
    CardVerification = ATMServiceTypeV2Code.CardVerification,

    /// <summary>
    /// Ask for customer profile with eventualy related account information.
    /// Encoded/decoded by serializers as &quot;CMPF&quot;.
    /// </summary>
    [EnumMember(Value = "CMPF")]
    [IsoId("_ATMServiceType12Code_CustomerProfile")]
    [Description(@"Ask for customer profile with eventualy related account information.")]
    CustomerProfile = ATMServiceTypeV2Code.CustomerProfile,

    /// <summary>
    /// Ask to a DCC service provider to qualify the currency conversion for the card.
    /// Encoded/decoded by serializers as &quot;DCCS&quot;.
    /// </summary>
    [EnumMember(Value = "DCCS")]
    [IsoId("_ATMServiceType12Code_DynamicCurrencyConversion")]
    [Description(@"Ask to a DCC service provider to qualify the currency conversion for the card.")]
    DynamicCurrencyConversion = ATMServiceTypeV2Code.DynamicCurrencyConversion,

    /// <summary>
    /// Select the EMV applications allowed by the acquirer.
    /// Encoded/decoded by serializers as &quot;EMVS&quot;.
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_ATMServiceType12Code_SelectEMVApplication")]
    [Description(@"Select the EMV applications allowed by the acquirer.")]
    SelectEMVApplication = ATMServiceTypeV2Code.SelectEMVApplication,

    /// <summary>
    /// Request a mini-statement (i.e. partial statement) related to a customer account.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_ATMServiceType12Code_MiniStatement")]
    [Description(
        @"Request a mini-statement (i.e. partial statement) related to a customer account."
    )]
    MiniStatement = ATMServiceTypeV2Code.MiniStatement,

    /// <summary>
    /// Ask for exchange rate for the ongoing deposit transaction.
    /// Encoded/decoded by serializers as &quot;XRTD&quot;.
    /// </summary>
    [EnumMember(Value = "XRTD")]
    [IsoId("_ATMServiceType12Code_ExchangeRateDeposit")]
    [Description(@"Ask for exchange rate for the ongoing deposit transaction.")]
    ExchangeRateDeposit = ATMServiceTypeV2Code.ExchangeRateDeposit,

    /// <summary>
    /// Ask for exchange rate for the ongoing withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;XRTW&quot;.
    /// </summary>
    [EnumMember(Value = "XRTW")]
    [IsoId("_ATMServiceType12Code_ExchangeRateWithdrawal")]
    [Description(@"Ask for exchange rate for the ongoing withdrawal transaction.")]
    ExchangeRateWithdrawal = ATMServiceTypeV2Code.ExchangeRateWithdrawal,
}
