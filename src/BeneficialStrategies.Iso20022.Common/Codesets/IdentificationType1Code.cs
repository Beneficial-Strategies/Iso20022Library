// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the source of the party identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Huj2wIA6EeSUJZYcWGKkkw")]
[Description(@"Indicates the source of the party identification.")]
[DerivedFrom(typeof(IdentificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<IdentificationType1Code>))]
#endif
public enum IdentificationType1Code
{
    /// <summary>
    /// Specified source is bank.
    /// Encoded/decoded by serializers as &quot;BASC&quot;.
    /// </summary>
    [EnumMember(Value = "BASC")]
    [IsoId("_NBIjoYA6EeSUJZYcWGKkkw")]
    [Description(@"Specified source is bank.")]
    BankSortCode = IdentificationTypeCode.BankSortCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BIC code defines as a standard format of business identifier code. It is a unique identification code for both financial and non-financial institutions.
    /// Encoded/decoded by serializers as &quot;BICO&quot;.
    /// </summary>
    [EnumMember(Value = "BICO")]
    [IsoId("_NGDf4YA6EeSUJZYcWGKkkw")]
    [Description(
        @"BIC code defines as a standard format of business identifier code. It is a unique identification code for both financial and non-financial institutions."
    )]
    BIC = IdentificationTypeCode.BIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CFETS is an abbreviation of China Foreign Exchange Trade System, which is a sub-institution of the PBC. Its main functions include: providing systems for FX trading, RMB lending, bond trading and exchange rate and interest rate derivatives trading; organizing FX trading, RMB lending, bond trading, and exchange rate and interest rate derivatives trading; providing clearing, information, risk management, and surveillance services on interbank markets; and engaging in other businesses authorized by the PBC.
    /// Encoded/decoded by serializers as &quot;CFET&quot;.
    /// </summary>
    [EnumMember(Value = "CFET")]
    [IsoId("_NLYEwYA6EeSUJZYcWGKkkw")]
    [Description(
        @"CFETS is an abbreviation of China Foreign Exchange Trade System, which is a sub-institution of the PBC. Its main functions include: providing systems for FX trading, RMB lending, bond trading and exchange rate and interest rate derivatives trading; organizing FX trading, RMB lending, bond trading, and exchange rate and interest rate derivatives trading; providing clearing, information, risk management, and surveillance services on interbank markets; and engaging in other businesses authorized by the PBC."
    )]
    CFETS = IdentificationTypeCode.CFETS, // same ordinal as derivation source for type conversions
}
