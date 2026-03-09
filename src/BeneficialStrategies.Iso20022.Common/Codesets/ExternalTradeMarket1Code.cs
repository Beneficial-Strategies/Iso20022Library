// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external trade market code in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NzE0NzM2-AOSNFX-5096928")]
[Description(@"Specifies the external trade market code in the format of character string with a maximum length of 4 characters.|External code sets can be downloaded from www.iso20022.org.|")]
[DerivedFrom(typeof(ExternalTradeMarketCode))]
public enum ExternalTradeMarket1Code
{
    /// <summary>
    /// Factoring service provider, Factoring client and third party in the same country
    /// Encoded/decoded by serializers as &quot;FDMS&quot;.
    /// </summary>
    [EnumMember(Value = "FDMS")]
    [IsoId("_uTUAmPRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client and third party in the same country")]
    FactoringDomestic = ExternalTradeMarketCode.FactoringDomestic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider, Factoring client in the same country, third party in another country
    /// Encoded/decoded by serializers as &quot;FEXP&quot;.
    /// </summary>
    [EnumMember(Value = "FEXP")]
    [IsoId("_uTUAm_RYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client in the same country, third party in another country")]
    FactoringExport = ExternalTradeMarketCode.FactoringExport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring client and third party in the same country, Factoring service provider in another country
    /// Encoded/decoded by serializers as &quot;FFDM&quot;.
    /// </summary>
    [EnumMember(Value = "FFDM")]
    [IsoId("_uTdKgvRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring client and third party in the same country, Factoring service provider in another country")]
    FactoringForeignDomestic = ExternalTradeMarketCode.FactoringForeignDomestic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider, Factoring client and third party in the same country, but factoring client has an exceptional VAT ruling, for example if it’s overseas
    /// Encoded/decoded by serializers as &quot;FFDT&quot;.
    /// </summary>
    [EnumMember(Value = "FFDT")]
    [IsoId("_uTdKhfRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client and third party in the same country, but factoring client has an exceptional VAT ruling, for example if it’s overseas")]
    FactoringFrenchDomTom = ExternalTradeMarketCode.FactoringFrenchDomTom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider and third party in the same country, Factoring client in another country
    /// Encoded/decoded by serializers as &quot;FIMP&quot;.
    /// </summary>
    [EnumMember(Value = "FIMP")]
    [IsoId("_uTdKiPRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider and third party in the same country, Factoring client in another country")]
    FactoringImport = ExternalTradeMarketCode.FactoringImport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider, Factoring client and third party in three different countries
    /// Encoded/decoded by serializers as &quot;FREX&quot;.
    /// </summary>
    [EnumMember(Value = "FREX")]
    [IsoId("_uTdKi_RYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client and third party in three different countries")]
    FactoringReexportedExport = ExternalTradeMarketCode.FactoringReexportedExport, // same ordinal as derivation source for type conversions
    
}
