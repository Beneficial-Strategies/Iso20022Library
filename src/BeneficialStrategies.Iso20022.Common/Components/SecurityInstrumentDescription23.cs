// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_hepx8ZiqEe2f7NHvXATP5g")]
[DisplayName("Security Instrument Description")]
public partial record SecurityInstrumentDescription23
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_hhBJcZiqEe2f7NHvXATP5g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Identification { get; init; } 
    
    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_k7vj4JiqEe2f7NHvXATP5g")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public OtherIdentification1? OtherIdentification { get; init; } 
    
    /// <summary>
    /// Full name or description of the financial instrument.
    /// </summary>
    [IsoId("_hhBJc5iqEe2f7NHvXATP5g")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text FullName { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO classification of financial instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_hhBJdZiqEe2f7NHvXATP5g")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public required IsoCFIOct2015Identifier ClassificationType { get; init; } 
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_hhBwgZiqEe2f7NHvXATP5g")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrency { get; init; } 
    
    
    #nullable disable
    
}
