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
[IsoId("_Q1Ld4XR1EeiH1ZOt2UD8vQ")]
[DisplayName("Document")]
public partial record Document12
{
    #nullable enable
    
    /// <summary>
    /// Type of document or template.
    /// </summary>
    [IsoId("_Q_AvUXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DocumentType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Identification of the document or template.
    /// </summary>
    [IsoId("_Q_AvU3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Issue date or date time of the document.
    /// </summary>
    [IsoId("_3iRlYXiJEeidzqjNEfehPg")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public required DateAndDateTime2Choice_ IssueDate { get; init; } 
    
    /// <summary>
    /// Name of document or transaction, for example, tax invoice.
    /// </summary>
    [IsoId("_E_8EYniKEeidzqjNEfehPg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    /// <summary>
    /// Unique identifier for a language used in the document.
    /// </summary>
    [IsoId("_E_8EY3iKEeidzqjNEfehPg")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; } 
    
    /// <summary>
    /// Format of the document or template, such as PDF, XML, XSLT.
    /// </summary>
    [IsoId("_Q_AvVXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public required DocumentFormat1Choice_ Format { get; init; } 
    
    /// <summary>
    /// Technical name of the file.
    /// </summary>
    [IsoId("_ZEDS8XiKEeidzqjNEfehPg")]
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? FileName { get; init; } 
    
    /// <summary>
    /// Digital signature of the enclosed binary file.
    /// </summary>
    [IsoId("_Q_AvWXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; } 
    
    /// <summary>
    /// Binary file representing the enclosed document or template, such as a PDF file, image file, XML file, MT message.
    /// </summary>
    [IsoId("_Q_AvV3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    [IsoSimpleType(IsoSimpleType.Max10MbBinary)]
    public required IsoMax10MbBinary Enclosure { get; init; } 
    
    
    #nullable disable
    
}
