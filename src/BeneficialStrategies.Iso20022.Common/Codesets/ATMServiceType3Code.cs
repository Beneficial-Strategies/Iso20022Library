// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of inquiry selected by the customer or the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GHNZAIqvEeSIDtZ76p6McQ")]
[Description(@"Describes the type of inquiry selected by the customer or the ATM.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMServiceType3Code>))]
#endif
public enum ATMServiceType3Code
{
    /// <summary>
    /// Ask for account statement information to a related custumer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_NzZooYqvEeSIDtZ76p6McQ")]
    [Description(@"Ask for account statement information to a related custumer account.")]
    AccountStatements = ATMServiceTypeCode.AccountStatements, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification of the card.
    /// Encoded/decoded by serializers as &quot;CDVF&quot;.
    /// </summary>
    [EnumMember(Value = "CDVF")]
    [IsoId("_OGUko4qvEeSIDtZ76p6McQ")]
    [Description(@"Verification of the card.")]
    CardVerification = ATMServiceTypeCode.CardVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask to a DCC service provider to qualify the currency conversion for the card.
    /// Encoded/decoded by serializers as &quot;DCCS&quot;.
    /// </summary>
    [EnumMember(Value = "DCCS")]
    [IsoId("_OZjCo4qvEeSIDtZ76p6McQ")]
    [Description(@"Ask to a DCC service provider to qualify the currency conversion for the card.")]
    DynamicCurrencyConversion = ATMServiceTypeCode.DynamicCurrencyConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask for exchange rate for the ongoing deposit transaction.
    /// Encoded/decoded by serializers as &quot;XRTD&quot;.
    /// </summary>
    [EnumMember(Value = "XRTD")]
    [IsoId("_PZLTo4qvEeSIDtZ76p6McQ")]
    [Description(@"Ask for exchange rate for the ongoing deposit transaction.")]
    ExchangeRateDeposit = ATMServiceTypeCode.ExchangeRateDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask for exchange rate for the ongoing withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;XRTW&quot;.
    /// </summary>
    [EnumMember(Value = "XRTW")]
    [IsoId("_Ph0SQ4qvEeSIDtZ76p6McQ")]
    [Description(@"Ask for exchange rate for the ongoing withdrawal transaction.")]
    ExchangeRateWithdrawal = ATMServiceTypeCode.ExchangeRateWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Select the EMV applications allowed by the acquirer.
    /// Encoded/decoded by serializers as &quot;EMVS&quot;.
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_QYW4s4qvEeSIDtZ76p6McQ")]
    [Description(@"Select the EMV applications allowed by the acquirer.")]
    SelectEMVApplication = ATMServiceTypeCode.SelectEMVApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask for customer profile with eventualy related account information.
    /// Encoded/decoded by serializers as &quot;CMPF&quot;.
    /// </summary>
    [EnumMember(Value = "CMPF")]
    [IsoId("_Ix3Kkec3EeSW7vQF-KSwOA")]
    [Description(@"Ask for customer profile with eventualy related account information.")]
    CustomerProfile = ATMServiceTypeCode.CustomerProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_wiCi8egaEeSbJsoAnSuiCQ")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry = ATMServiceTypeCode.BalanceInquiry, // same ordinal as derivation source for type conversions
}
