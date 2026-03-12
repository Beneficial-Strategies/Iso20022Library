// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a date of issue.
/// </summary>
[IsoId("_SuJtIgEcEeCQm6a_G2yO_w_-589377651")]
[DisplayName("Document Identification")]
public partial record DocumentIdentification22
{
    #nullable enable
    
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_SuJtIwEcEeCQm6a_G2yO_w_-703216717")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date of issuance of the document.
    /// </summary>
    [IsoId("_SuJtJAEcEeCQm6a_G2yO_w_-1586450004")]
    [DisplayName("Date Of Issue")]
    [IsoXmlTag("DtOfIsse")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfIssue { get; init; } 
    
    
    #nullable disable
    
}
