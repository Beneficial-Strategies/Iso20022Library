// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a document.
/// </summary>
[IsoId("_wy9ZETEyEe6g-ffJsqGiSA")]
public interface IDocument15 : IIsoComponent
{
    /// <summary>
    /// Digital signature of the enclosed binary file.
    /// </summary>
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    IPartyAndSignature4? DigitalSignature { get; }

    /// <summary>
    /// Binary file representing the enclosed document or template, such as a PDF file, image file, XML file, MT message.
    /// </summary>
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    IsoMax10MbBinary Enclosure { get; }

    /// <summary>
    /// Technical name of the file.
    /// </summary>
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    IsoMax140Text? FileName { get; }

    /// <summary>
    /// Format of the document or template, such as PDF, XML, XSLT.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    IDocumentFormat1Choice Format { get; }

    /// <summary>
    /// Identification of the document or template.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax35Text Identification { get; }

    /// <summary>
    /// Issue date or date time of the document.
    /// </summary>
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    IDateAndDateTime2Choice IssueDate { get; }

    /// <summary>
    /// Unique identifier for a language used in the document.
    /// </summary>
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    LanguageCode? LanguageCode { get; }

    /// <summary>
    /// Name of document or transaction, for example, tax invoice.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Type of document or template.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDocumentType1Choice Type { get; }
}
