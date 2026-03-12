// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial instrument and of the non-equity sub-class of the financial instrument.
/// </summary>
[IsoId("_GUulYaaUEeqZmriXpMtonA")]
[DisplayName("Instrument And Sub Class Identification")]
public partial record InstrumentAndSubClassIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_GWXkIaaUEeqZmriXpMtonA")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier ISIN { get; init; } 
    
    /// <summary>
    /// Sub class of non-equity instruments to which the instrument belongs.
    /// </summary>
    [IsoId("_GWXkI6aUEeqZmriXpMtonA")]
    [DisplayName("Derivative Sub Class")]
    [IsoXmlTag("DerivSubClss")]
    public NonEquitySubClass1? DerivativeSubClass { get; init; } 
    
    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    [IsoId("_GWXkJaaUEeqZmriXpMtonA")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    
    
    #nullable disable
    
}
