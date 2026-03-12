// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a document.
/// </summary>
[IsoId("_96YbSXltEeG7BsjMvd1mEw_-172031402")]
[DisplayName("Document")]
public partial record Document10
{
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_96YbSnltEeG7BsjMvd1mEw_-1696622720")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    public required UndertakingDocumentType2Choice_ DocumentType { get; init; } 
    
    /// <summary>
    /// Channel through which the document should be presented.
    /// </summary>
    [IsoId("_96iMQHltEeG7BsjMvd1mEw_1601272223")]
    [DisplayName("Presentation Channel")]
    [IsoXmlTag("PresntnChanl")]
    public Channel1Choice_? PresentationChannel { get; init; } 
    
    /// <summary>
    /// Format of the document.
    /// </summary>
    [IsoId("_96iMQXltEeG7BsjMvd1mEw_681238571")]
    [DisplayName("Document Format")]
    [IsoXmlTag("DocFrmt")]
    public DocumentFormat1Choice_? DocumentFormat { get; init; } 
    
    /// <summary>
    /// Indication whether the document may be a copy of the original document.
    /// </summary>
    [IsoId("_96iMQnltEeG7BsjMvd1mEw_1954061068")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CopyIndicator { get; init; } 
    
    /// <summary>
    /// Indication whether the document must be signed.
    /// </summary>
    [IsoId("_96iMQ3ltEeG7BsjMvd1mEw_1042190213")]
    [DisplayName("Signed Indicator")]
    [IsoXmlTag("SgndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SignedIndicator { get; init; } 
    
    
    #nullable disable
    
}
