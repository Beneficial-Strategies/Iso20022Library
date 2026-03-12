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
[IsoId("_1x58kcnTEeWpf-ImB_F2gQ")]
[DisplayName("Security Instrument Description")]
public partial record SecurityInstrumentDescription11
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_2J6z8cnTEeWpf-ImB_F2gQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Identification { get; init; } 
    
    /// <summary>
    /// Full name or description of the financial instrument.
    /// </summary>
    [IsoId("_2J6z88nTEeWpf-ImB_F2gQ")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text FullName { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO classification of financial instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_2J6z98nTEeWpf-ImB_F2gQ")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public required IsoCFIOct2015Identifier ClassificationType { get; init; } 
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_2J6z-8nTEeWpf-ImB_F2gQ")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrency { get; init; } 
    
    
    #nullable disable
    
}
