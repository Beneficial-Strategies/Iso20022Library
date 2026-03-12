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
[IsoId("_cLR5seLXEeWFtOV72FbX9w")]
[DisplayName("Collateral Value")]
public partial record CollateralValue2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_cWS24eLXEeWFtOV72FbX9w")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Valuation date for the price.
    /// </summary>
    [IsoId("_cWS24-LXEeWFtOV72FbX9w")]
    [DisplayName("Valuation Date")]
    [IsoXmlTag("ValtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValuationDate { get; init; } 
    
    /// <summary>
    /// Provides details of the currency of the valuation.
    /// </summary>
    [IsoId("_cWS25eLXEeWFtOV72FbX9w")]
    [DisplayName("Valuation Currency")]
    [IsoXmlTag("ValtnCcy")]
    public ActiveCurrencyCode? ValuationCurrency { get; init; } 
    
    /// <summary>
    /// Provides details of the price provided for the security.
    /// </summary>
    [IsoId("_cWS25-LXEeWFtOV72FbX9w")]
    [DisplayName("Valuation Price")]
    [IsoXmlTag("ValtnPric")]
    public required AmountOrCoefficientPrice1Choice_ ValuationPrice { get; init; } 
    
    
    #nullable disable
    
}
