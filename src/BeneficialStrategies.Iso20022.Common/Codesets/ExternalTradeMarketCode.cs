// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external trade market code in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NzE0NzM1-AOSNFX-5096928")]
[Description(
    @"Specifies the external trade market code in the format of character string with a maximum length of 4 characters.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalTradeMarket1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalTradeMarketCode>))]
#endif
public enum ExternalTradeMarketCode
{
    /// <summary>
    /// Factoring service provider, Factoring client and third party in the same country
    /// Encoded/decoded by serializers as &quot;FDMS&quot;.
    /// </summary>
    [EnumMember(Value = "FDMS")]
    [IsoId("_uTUAlvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Factoring service provider, Factoring client and third party in the same country"
    )]
    FactoringDomestic,

    /// <summary>
    /// Factoring service provider, Factoring client in the same country, third party in another country
    /// Encoded/decoded by serializers as &quot;FEXP&quot;.
    /// </summary>
    [EnumMember(Value = "FEXP")]
    [IsoId("_uTUAmfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Factoring service provider, Factoring client in the same country, third party in another country"
    )]
    FactoringExport,

    /// <summary>
    /// Factoring client and third party in the same country, Factoring service provider in another country
    /// Encoded/decoded by serializers as &quot;FFDM&quot;.
    /// </summary>
    [EnumMember(Value = "FFDM")]
    [IsoId("_uTdKgPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Factoring client and third party in the same country, Factoring service provider in another country"
    )]
    FactoringForeignDomestic,

    /// <summary>
    /// Factoring service provider, Factoring client and third party in the same country, but factoring client has an exceptional VAT ruling, for example if it’s overseas
    /// Encoded/decoded by serializers as &quot;FFDT&quot;.
    /// </summary>
    [EnumMember(Value = "FFDT")]
    [IsoId("_uTdKg_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Factoring service provider, Factoring client and third party in the same country, but factoring client has an exceptional VAT ruling, for example if it’s overseas"
    )]
    FactoringFrenchDomTom,

    /// <summary>
    /// Factoring service provider and third party in the same country, Factoring client in another country
    /// Encoded/decoded by serializers as &quot;FIMP&quot;.
    /// </summary>
    [EnumMember(Value = "FIMP")]
    [IsoId("_uTdKhvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Factoring service provider and third party in the same country, Factoring client in another country"
    )]
    FactoringImport,

    /// <summary>
    /// Factoring service provider, Factoring client and third party in three different countries
    /// Encoded/decoded by serializers as &quot;FREX&quot;.
    /// </summary>
    [EnumMember(Value = "FREX")]
    [IsoId("_uTdKifRYEeuLhpyIdtJzwg")]
    [Description(
        @"Factoring service provider, Factoring client and third party in three different countries"
    )]
    FactoringReexportedExport,
}
