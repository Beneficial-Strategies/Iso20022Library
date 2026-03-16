// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of confirmed fraud.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aFPakHa6Eeef9c2nwgY9Xw")]
[Description(@"Type of confirmed fraud.")]
[Derivations(typeof(FraudType1Code))]
public enum FraudTypeCode
{
    /// <summary>
    /// Fraudulent transaction with a card that has been reported as lost
    /// Encoded/decoded by serializers as &quot;CRDL&quot;.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_fRdAwHa6Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent transaction with a card that has been reported as lost")]
    LostCard,

    /// <summary>
    /// Fraudulent transaction with a card that has been reported as stolen.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_9I6YsHa6Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent transaction with a card that has been reported as stolen.")]
    StolenCard,

    /// <summary>
    /// Fraudulent transaction with a card that was not received by the cardholder.
    /// Encoded/decoded by serializers as &quot;CRNT&quot;.
    /// </summary>
    [EnumMember(Value = "CRNT")]
    [IsoId("_MsgpcHa7Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent transaction with a card that was not received by the cardholder.")]
    CardNotReceived,

    /// <summary>
    /// Fraudulent transaction on an account that the cardholder never applied for or the information on the application was falsified.
    /// Encoded/decoded by serializers as &quot;FRAP&quot;.
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("_bI-6EHa7Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction on an account that the cardholder never applied for or the information on the application was falsified."
    )]
    FraudulentApplication,

    /// <summary>
    /// Fraudulent use of an account.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_zhc5wHa7Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent use of an account.")]
    FraudulentAccountUse,

    /// <summary>
    /// Fraudulent transaction with an altered or duplicated card in a card-present environment where the cardholder did not knowingly participate or the account was not created.
    /// Encoded/decoded by serializers as &quot;CWKA&quot;.
    /// </summary>
    [EnumMember(Value = "CWKA")]
    [IsoId("_H6MUgHa8Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction with an altered or duplicated card in a card-present environment where the cardholder did not knowingly participate or the account was not created."
    )]
    CounterfeitWithExistingAccount,

    /// <summary>
    /// Fraudulent transaction where the acquirer confirmed that the IIN (Issuer Identification Number) used was either never issued or is invalid.
    /// Encoded/decoded by serializers as &quot;CWUI&quot;.
    /// </summary>
    [EnumMember(Value = "CWUI")]
    [IsoId("_hueK4Ha8Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction where the acquirer confirmed that the IIN (Issuer Identification Number) used was either never issued or is invalid."
    )]
    CounterfeitWithUnassignedIIN,

    /// <summary>
    /// Fraudulent transaction due to the unauthorised use of a card account by a person with the intent to defraud the issuer of the card.
    /// Encoded/decoded by serializers as &quot;ACTO&quot;.
    /// </summary>
    [EnumMember(Value = "ACTO")]
    [IsoId("_L2160Ha9Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction due to the unauthorised use of a card account by a person with the intent to defraud the issuer of the card."
    )]
    AccountTakeover,

    /// <summary>
    /// Fraudulent transaction that cannot be categorised as one of the standard fraud types.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_gy3zYHa-Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction that cannot be categorised as one of the standard fraud types."
    )]
    Miscellaneous,

    /// <summary>
    /// Other type of fraud defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_r7peoHa-Eeef9c2nwgY9Xw")]
    [Description(@"Other type of fraud defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of fraud defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_w6UYEHa-Eeef9c2nwgY9Xw")]
    [Description(@"Other type of fraud defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Fraudulent use in a card-not-present environment of an account.
    /// Encoded/decoded by serializers as &quot;CNPA&quot;.
    /// </summary>
    [EnumMember(Value = "CNPA")]
    [IsoId("_T-nTEJgCEee-7IkMvqfAcA")]
    [Description(@"Fraudulent use in a card-not-present environment of an account.")]
    CardNotPresentAccountUse,

    /// <summary>
    /// Merchant makes additional transactions against a card when consumer authorised for one legitimate transaction.
    /// Encoded/decoded by serializers as &quot;MUFD&quot;.
    /// </summary>
    [EnumMember(Value = "MUFD")]
    [IsoId("_VkpcMGdxEemXfKijhrqa-Q")]
    [Description(
        @"Merchant makes additional transactions against a card when consumer authorised for one legitimate transaction."
    )]
    MultipleUseFraud,

    /// <summary>
    /// Two parties colluding for the purpose of creating fraudulent transaction. For example, a cardholder and merchant.
    /// Encoded/decoded by serializers as &quot;COSN&quot;.
    /// </summary>
    [EnumMember(Value = "COSN")]
    [IsoId("_G-lVQGdyEemXfKijhrqa-Q")]
    [Description(
        @"Two parties colluding for the purpose of creating fraudulent transaction. For example, a cardholder and merchant. "
    )]
    Collusion,
}
