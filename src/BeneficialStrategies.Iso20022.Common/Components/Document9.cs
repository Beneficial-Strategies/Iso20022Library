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
[IsoId("_96r9QXltEeG7BsjMvd1mEw_1701053345")]
[DisplayName("Document")]
public partial record Document9
{
    #nullable enable
    
    /// <summary>
    /// Type of document or template.
    /// </summary>
    [IsoId("_96r9QnltEeG7BsjMvd1mEw_-1450988527")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required UndertakingDocumentType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Identification of the document or template.
    /// </summary>
    [IsoId("_96r9Q3ltEeG7BsjMvd1mEw_1198711334")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Format of the document or template, such as PDF, XML, XSLT.
    /// </summary>
    [IsoId("_96r9RHltEeG7BsjMvd1mEw_-1792505725")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public DocumentFormat1Choice_? Format { get; init; } 
    
    /// <summary>
    /// Binary file representing the enclosed document or template, such as a PDF file, image file, XML file, MT message.
    /// </summary>
    [IsoId("_961HMHltEeG7BsjMvd1mEw_-1712866325")]
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
    public required IsoMax2MBBinary Enclosure { get; init; } 
    
    /// <summary>
    /// Digital signature of the enclosed binary file.
    /// </summary>
    [IsoId("_961HMXltEeG7BsjMvd1mEw_-730056321")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}
