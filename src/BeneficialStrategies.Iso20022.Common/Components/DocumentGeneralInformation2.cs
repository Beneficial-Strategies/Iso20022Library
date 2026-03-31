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
[IsoId("_S-ZIkAEcEeCQm6a_G2yO_w_-1398499112")]
[DisplayName("Document General Information")]
public record DocumentGeneralInformation2
{
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_S-ZIkQEcEeCQm6a_G2yO_w_-1690456850")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    public required ExternalDocumentType1Code DocumentType { get; init; }

    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_S-ZIkgEcEeCQm6a_G2yO_w_-1512338178")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DocumentNumber { get; init; }

    /// <summary>
    /// Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_S-ZIkwEcEeCQm6a_G2yO_w_-166388554")]
    [DisplayName("Sender Receiver Sequence Identification")]
    [IsoXmlTag("SndrRcvrSeqId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SenderReceiverSequenceIdentification { get; init; }

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_S-ZIlAEcEeCQm6a_G2yO_w_-1163460907")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// URL (Uniform Resource Locator) where the document can be found.
    /// </summary>
    [IsoId("_S-ZIlQEcEeCQm6a_G2yO_w_2134434036")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URL { get; init; }

    /// <summary>
    /// Attached binary file for this document.
    /// </summary>
    [IsoId("_S-ZIlgEcEeCQm6a_G2yO_w_1137361683")]
    [DisplayName("Attached Binary File")]
    [IsoXmlTag("AttchdBinryFile")]
    public ValueList<BinaryFile1> AttachedBinaryFile { get; init; } = [];
}
