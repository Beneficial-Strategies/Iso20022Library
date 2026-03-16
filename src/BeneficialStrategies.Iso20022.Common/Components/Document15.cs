// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document15.
/// </summary>
[IsoId("_wy9ZETEyEe6g-ffJsqGiSA")]
[DisplayName("Document15")]
public partial record Document15
{
    #nullable enable

    /// <summary>
    /// Digital Signature.
    /// </summary>
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature4? DigitalSignature { get; init; } 

    /// <summary>
    /// Enclosure.
    /// </summary>
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    public required IsoMax10MbBinary Enclosure { get; init; } 

    /// <summary>
    /// File Name.
    /// </summary>
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    public IsoMax140Text? FileName { get; init; } 

    /// <summary>
    /// Format.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public required DocumentFormat1Choice_ Format { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; } 

    /// <summary>
    /// Issue Date.
    /// </summary>
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public required DateAndDateTime2Choice_ IssueDate { get; init; } 

    /// <summary>
    /// Language Code.
    /// </summary>
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DocumentType1Choice_ Type { get; init; } 

    
    #nullable disable
    
}
