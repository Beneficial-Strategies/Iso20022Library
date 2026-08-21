// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a document.
/// </summary>
[IsoId("_wy9ZETEyEe6g-ffJsqGiSA")]
[Description(@"Information about a document.")]
[DisplayName("Document15")]
public record Document15
{
    /// <summary>
    /// Digital signature of the enclosed binary file.
    /// </summary>
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature4? DigitalSignature { get; init; }

    /// <summary>
    /// Binary file representing the enclosed document or template, such as a PDF file, image file, XML file, MT message.
    /// </summary>
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    public required IsoMax10MbBinary Enclosure { get; init; }

    /// <summary>
    /// Technical name of the file.
    /// </summary>
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    public IsoMax140Text? FileName { get; init; }

    /// <summary>
    /// Format of the document or template, such as PDF, XML, XSLT.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public required DocumentFormat1Choice_ Format { get; init; }

    /// <summary>
    /// Identification of the document or template.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Issue date or date time of the document.
    /// </summary>
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public required DateAndDateTime2Choice_ IssueDate { get; init; }

    /// <summary>
    /// Unique identifier for a language used in the document.
    /// </summary>
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; }

    /// <summary>
    /// Name of document or transaction, for example, tax invoice.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Type of document or template.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DocumentType1Choice_ Type { get; init; }
}
