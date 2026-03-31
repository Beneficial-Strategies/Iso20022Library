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
[IsoId("_ThV909p-Ed-ak6NoX_4Aeg_568243835")]
[DisplayName("Document General Information")]
public record DocumentGeneralInformation1
{
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_ThV91Np-Ed-ak6NoX_4Aeg_568243837")]
    [DisplayName("Document Type")]
    [IsoXmlTag("DocTp")]
    public required DocumentType4Code DocumentType { get; init; }

    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_ThV91dp-Ed-ak6NoX_4Aeg_568243853")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DocumentNumber { get; init; }

    /// <summary>
    /// Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_ThV91tp-Ed-ak6NoX_4Aeg_568243878")]
    [DisplayName("Sender Receiver Sequence Identification")]
    [IsoXmlTag("SndrRcvrSeqId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SenderReceiverSequenceIdentification { get; init; }

    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_ThfHwNp-Ed-ak6NoX_4Aeg_568243895")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; }

    /// <summary>
    /// URL (Uniform Resource Locator) related to the document.
    /// </summary>
    [IsoId("_ThfHwdp-Ed-ak6NoX_4Aeg_568243913")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? URL { get; init; }
}
