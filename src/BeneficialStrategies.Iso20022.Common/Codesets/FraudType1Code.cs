// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of fraud in a card payment environment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4htAMHa-Eeef9c2nwgY9Xw")]
[Description(@"Identifies the type of fraud in a card payment environment.")]
[DerivedFrom(typeof(FraudTypeCode))]
public enum FraudType1Code
{
    /// <summary>
    /// Fraudulent transaction due to the unauthorised use of a card account by a person with the intent to defraud the issuer of the card.
    /// Encoded/decoded by serializers as &quot;ACTO&quot;.
    /// </summary>
    [EnumMember(Value = "ACTO")]
    [IsoId("_9_BkgXa-Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction due to the unauthorised use of a card account by a person with the intent to defraud the issuer of the card."
    )]
    AccountTakeover = FraudTypeCode.AccountTakeover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction where the acquirer confirmed that the IIN (Issuer Identification Number) used was either never issued or is invalid.
    /// Encoded/decoded by serializers as &quot;CWUI&quot;.
    /// </summary>
    [EnumMember(Value = "CWUI")]
    [IsoId("_-JcEwXa-Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction where the acquirer confirmed that the IIN (Issuer Identification Number) used was either never issued or is invalid."
    )]
    CounterfeitWithUnassignedIIN = FraudTypeCode.CounterfeitWithUnassignedIIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction with a card that was not received by the cardholder.
    /// Encoded/decoded by serializers as &quot;CRNT&quot;.
    /// </summary>
    [EnumMember(Value = "CRNT")]
    [IsoId("_-mcw4Xa-Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent transaction with a card that was not received by the cardholder.")]
    CardNotReceived = FraudTypeCode.CardNotReceived, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent use of an account.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_-_SusXa-Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent use of an account.")]
    FraudulentAccountUse = FraudTypeCode.FraudulentAccountUse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction on an account that the cardholder never applied for or the information on the application was falsified.
    /// Encoded/decoded by serializers as &quot;FRAP&quot;.
    /// </summary>
    [EnumMember(Value = "FRAP")]
    [IsoId("__LpIoXa-Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction on an account that the cardholder never applied for or the information on the application was falsified."
    )]
    FraudulentApplication = FraudTypeCode.FraudulentApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction with an altered or duplicated card in a card-present environment where the cardholder did not knowingly participate or the account was not created.
    /// Encoded/decoded by serializers as &quot;CWKA&quot;.
    /// </summary>
    [EnumMember(Value = "CWKA")]
    [IsoId("__Xi2oXa-Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction with an altered or duplicated card in a card-present environment where the cardholder did not knowingly participate or the account was not created."
    )]
    CounterfeitWithExistingAccount = FraudTypeCode.CounterfeitWithExistingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction with a card that has been reported as lost
    /// Encoded/decoded by serializers as &quot;CRDL&quot;.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("__mIFMXa-Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent transaction with a card that has been reported as lost")]
    LostCard = FraudTypeCode.LostCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction that cannot be categorised as one of the standard fraud types.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("__vgDoXa-Eeef9c2nwgY9Xw")]
    [Description(
        @"Fraudulent transaction that cannot be categorised as one of the standard fraud types."
    )]
    Miscellaneous = FraudTypeCode.Miscellaneous, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of fraud defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("__5K9AXa-Eeef9c2nwgY9Xw")]
    [Description(@"Other type of fraud defined at national level.")]
    OtherNational = FraudTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of fraud defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_AF9b0Xa_Eeef9c2nwgY9Xw")]
    [Description(@"Other type of fraud defined at private level.")]
    OtherPrivate = FraudTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction with a card that has been reported as stolen.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_AOvkYXa_Eeef9c2nwgY9Xw")]
    [Description(@"Fraudulent transaction with a card that has been reported as stolen.")]
    StolenCard = FraudTypeCode.StolenCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent use in a card-not-present environment of an account.
    /// Encoded/decoded by serializers as &quot;CNPA&quot;.
    /// </summary>
    [EnumMember(Value = "CNPA")]
    [IsoId("_0o1GgZgCEee-7IkMvqfAcA")]
    [Description(@"Fraudulent use in a card-not-present environment of an account.")]
    CardNotPresentAccountUse = FraudTypeCode.CardNotPresentAccountUse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant makes additional transactions against a card when consumer authorised for one legitimate transaction.
    /// Encoded/decoded by serializers as &quot;MUFD&quot;.
    /// </summary>
    [EnumMember(Value = "MUFD")]
    [IsoId("_IFiwUWzjEemD24gVaMSpeA")]
    [Description(
        @"Merchant makes additional transactions against a card when consumer authorised for one legitimate transaction."
    )]
    MultipleUseFraud = FraudTypeCode.MultipleUseFraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Two parties colluding for the purpose of creating fraudulent transaction. For example, a cardholder and merchant.
    /// Encoded/decoded by serializers as &quot;COSN&quot;.
    /// </summary>
    [EnumMember(Value = "COSN")]
    [IsoId("_PaqjwWzjEemD24gVaMSpeA")]
    [Description(
        @"Two parties colluding for the purpose of creating fraudulent transaction. For example, a cardholder and merchant. "
    )]
    Collusion = FraudTypeCode.Collusion, // same ordinal as derivation source for type conversions
}
