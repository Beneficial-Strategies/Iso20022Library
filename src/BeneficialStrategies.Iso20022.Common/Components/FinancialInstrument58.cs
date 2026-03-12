// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies underlying instruments or index a derivative has.
/// </summary>
[IsoId("_HYrJV35aEea2k7EBUopqxw")]
[DisplayName("Financial Instrument")]
public partial record FinancialInstrument58
{
    #nullable enable
    
    /// <summary>
    /// Identification of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_HhTg4X5aEea2k7EBUopqxw")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    
    /// <summary>
    /// Name of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_HhTg435aEea2k7EBUopqxw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required FloatingInterestRate8 Name { get; init; } 
    
    
    #nullable disable
    
}
