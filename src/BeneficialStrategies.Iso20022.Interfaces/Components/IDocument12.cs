// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a document.
/// </summary>
[IsoId("_Q1Ld4XR1EeiH1ZOt2UD8vQ")]
public interface IDocument12 : IIsoComponent
{
    /// <summary>
    /// Type of document or template.
    /// </summary>
    [IsoId("_Q_AvUXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDocumentType1Choice Type { get; }

    /// <summary>
    /// Identification of the document or template.
    /// </summary>
    [IsoId("_Q_AvU3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax35Text Identification { get; }

    /// <summary>
    /// Issue date or date time of the document.
    /// </summary>
    [IsoId("_3iRlYXiJEeidzqjNEfehPg")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    IDateAndDateTime2Choice IssueDate { get; }

    /// <summary>
    /// Name of document or transaction, for example, tax invoice.
    /// </summary>
    [IsoId("_E_8EYniKEeidzqjNEfehPg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Unique identifier for a language used in the document.
    /// </summary>
    [IsoId("_E_8EY3iKEeidzqjNEfehPg")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    LanguageCode? LanguageCode { get; }

    /// <summary>
    /// Format of the document or template, such as PDF, XML, XSLT.
    /// </summary>
    [IsoId("_Q_AvVXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    IDocumentFormat1Choice Format { get; }

    /// <summary>
    /// Technical name of the file.
    /// </summary>
    [IsoId("_ZEDS8XiKEeidzqjNEfehPg")]
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    IsoMax140Text? FileName { get; }

    /// <summary>
    /// Digital signature of the enclosed binary file.
    /// </summary>
    [IsoId("_Q_AvWXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    IPartyAndSignature3? DigitalSignature { get; }

    /// <summary>
    /// Binary file representing the enclosed document or template, such as a PDF file, image file, XML file, MT message.
    /// </summary>
    [IsoId("_Q_AvV3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Enclosure")]
    [IsoXmlTag("Nclsr")]
    IsoMax10MbBinary Enclosure { get; }
}
