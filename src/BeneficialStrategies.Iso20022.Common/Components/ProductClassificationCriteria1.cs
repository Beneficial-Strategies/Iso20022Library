// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Criteria regarding product classification.
/// </summary>
[IsoId("_hfq2Ux3YEeWNp95x0ENf8w")]
[DisplayName("Product Classification Criteria")]
public partial record ProductClassificationCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Identifier is an ISO 10962 Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_hfq2VR3YEeWNp95x0ENf8w")]
    [DisplayName("Classification Financial Instrument")]
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationFinancialInstrument { get; init; } 
    
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_hfq2VB3YEeWNp95x0ENf8w")]
    [DisplayName("Unique Product Identifier")]
    [IsoXmlTag("UnqPdctIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? UniqueProductIdentifier { get; init; } 
    
    
    #nullable disable
    
}
