// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the collateral reference data.
/// </summary>
[IsoId("_jAaZE-5NEeCisYr99QEiWA_851211093")]
[DisplayName("Collateral Value")]
public partial record CollateralValue1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_jAaZFO5NEeCisYr99QEiWA_-548343837")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public required IsoISINIdentifier SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Valuation date for the price.
    /// </summary>
    [IsoId("_jAkKEO5NEeCisYr99QEiWA_1592137702")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValuationDate { get; init; } 
    
    /// <summary>
    /// Provides details of the currency of the valuation.
    /// </summary>
    [IsoId("_jAkKEe5NEeCisYr99QEiWA_-1467045805")]
    [DisplayName("Valuation Currency")]
    [IsoXmlTag("ValtnCcy")]
    public ActiveCurrencyCode? ValuationCurrency { get; init; } 
    
    /// <summary>
    /// Provides details of the price provided for the security.
    /// </summary>
    [IsoId("_jAkKEu5NEeCisYr99QEiWA_2030771480")]
    [DisplayName("Valuation Price")]
    [IsoXmlTag("ValtnPric")]
    public required AmountOrCoefficientPrice1Choice_ ValuationPrice { get; init; } 
    
    
    #nullable disable
    
}
