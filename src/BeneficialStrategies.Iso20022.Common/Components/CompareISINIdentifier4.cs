// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an ISIN (International Securities Identification Number-ISO 6166) Identifier.
/// </summary>
[IsoId("_-Sbtoa5lEeuo-IflVgGqiA")]
[DisplayName("Compare ISIN Identifier")]
public partial record CompareISINIdentifier4
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_-he2Qa5lEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Value1 { get; init; } 
    
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_-he2Q65lEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Value2 { get; init; } 
    
    
    #nullable disable
    
}
