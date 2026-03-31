// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WAtaIDcVEeiIxKQErQxblg")]
[Description(
    @"Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060."
)]
[DerivedFrom(typeof(LegalStructureFinancialInstrumentCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LegalStructureFinancialInstrument1Code>))]
#endif
public enum LegalStructureFinancialInstrument1Code
{
    /// <summary>
    /// Legal structure is a not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUCI&quot;.
    /// </summary>
    [EnumMember(Value = "NUCI")]
    [IsoId("_X3bEITcVEeiIxKQErQxblg")]
    [Description(
        @"Legal structure is a not an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    NonUCITS = LegalStructureFinancialInstrumentCode.NonUCITS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is a structured fund.
    /// Encoded/decoded by serializers as &quot;SFUN&quot;.
    /// </summary>
    [EnumMember(Value = "SFUN")]
    [IsoId("_X74tYTcVEeiIxKQErQxblg")]
    [Description(@"Legal structure is a structured fund.")]
    StructuredFund = LegalStructureFinancialInstrumentCode.StructuredFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is a structured security.
    /// Encoded/decoded by serializers as &quot;SSEC&quot;.
    /// </summary>
    [EnumMember(Value = "SSEC")]
    [IsoId("_YANMsTcVEeiIxKQErQxblg")]
    [Description(@"Legal structure is a structured security.")]
    StructuredSecurity = LegalStructureFinancialInstrumentCode.StructuredSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;UCIT&quot;.
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_YE9w4TcVEeiIxKQErQxblg")]
    [Description(
        @"Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    UCITS = LegalStructureFinancialInstrumentCode.UCITS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is an exchange traded commodity.
    /// Encoded/decoded by serializers as &quot;EXTC&quot;.
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_atb8EYBgEei8Q7I_11BpAQ")]
    [Description(@"Legal structure is an exchange traded commodity.")]
    ExchangeTradedCommodity = LegalStructureFinancialInstrumentCode.ExchangeTradedCommodity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund.
    /// Encoded/decoded by serializers as &quot;UCMM&quot;.
    /// </summary>
    [EnumMember(Value = "UCMM")]
    [IsoId("_azh9AYBgEei8Q7I_11BpAQ")]
    [Description(
        @"Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund."
    )]
    UCITSMoneyMarketFund = LegalStructureFinancialInstrumentCode.UCITSMoneyMarketFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal structure is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUMM&quot;.
    /// </summary>
    [EnumMember(Value = "NUMM")]
    [IsoId("_LZpQ4YvwEeicrr-UkGlMQA")]
    [Description(
        @"Legal structure is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    NonUCITSMoneyMarketFund = LegalStructureFinancialInstrumentCode.NonUCITSMoneyMarketFund, // same ordinal as derivation source for type conversions
}
