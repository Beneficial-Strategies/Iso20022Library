// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information that unambiguously identifies a document, such as identification number and issue date time.
/// </summary>
[IsoId("_jFYWAdLQEeSdq5yU2aaSNw")]
[DisplayName("Document General Information")]
public record DocumentGeneralInformation3
{
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_jPf7UdLQEeSdq5yU2aaSNw")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    public required ExternalDocumentType1Code DocumentType { get; init; }

    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_jPf7U9LQEeSdq5yU2aaSNw")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DocumentNumber { get; init; }

    /// <summary>
    /// Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_jPf7VdLQEeSdq5yU2aaSNw")]
    [DisplayName("Sender Receiver Sequence Identification")]
    [IsoXmlTag("SndrRcvrSeqId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SenderReceiverSequenceIdentification { get; init; }

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_jPf7V9LQEeSdq5yU2aaSNw")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// URL (Uniform Resource Locator) where the document can be found.
    /// </summary>
    [IsoId("_jPf7WdLQEeSdq5yU2aaSNw")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URL { get; init; }

    /// <summary>
    /// Full Signature Structure without Signature itself:
    /// Hash + Certificate.
    /// </summary>
    [IsoId("_mpTIs9LQEeSdq5yU2aaSNw")]
    [DisplayName("Link File Hash")]
    [IsoXmlTag("LkFileHash")]
    public SignatureEnvelopeReference? LinkFileHash { get; init; }

    /// <summary>
    /// Attached binary file for this document.
    /// </summary>
    [IsoId("_jPf7W9LQEeSdq5yU2aaSNw")]
    [DisplayName("Attached Binary File")]
    [IsoXmlTag("AttchdBinryFile")]
    public required BinaryFile1 AttachedBinaryFile { get; init; }
}
