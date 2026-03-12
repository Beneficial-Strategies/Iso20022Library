// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates whether the supporting document is amending an original document or not, and the reference of the original supporting document, when applicable.
/// </summary>
[IsoId("_3IeEUNLlEeSDLevdaFPXHw")]
[DisplayName("Document Amendment")]
public partial record DocumentAmendment1
{
    #nullable enable
    
    /// <summary>
    /// Provides the correction sequence number used to identify the amendment.
    /// </summary>
    [IsoId("_7aD1UNLlEeSDLevdaFPXHw")]
    [DisplayName("Correction Identification")]
    [IsoXmlTag("CrrctnId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber CorrectionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the original document being amended.
    /// </summary>
    [IsoId("__vOewNLlEeSDLevdaFPXHw")]
    [DisplayName("Original Document Identification")]
    [IsoXmlTag("OrgnlDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalDocumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
