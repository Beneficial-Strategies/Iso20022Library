// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.pain;

/// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV07"/>
[Description(
    @"The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file)."
)]
[IsoId("_eYI_722PEei3KuUgpx7Xcw")]
[DisplayName("Creditor Payment Activation Request Status Report V")]
public partial record CreditorPaymentActivationRequestStatusReportV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.014.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReqStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.014.001.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV07.GroupHeader"/>
    [IsoId("_eYI_-22PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader87 GroupHeader { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV07.OriginalGroupInformationAndStatus"/>
    [IsoId("_eYI__W2PEei3KuUgpx7Xcw")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public required OriginalGroupInformation30 OriginalGroupInformationAndStatus { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV07.OriginalPaymentInformationAndStatus"/>
    [IsoId("_eYI__22PEei3KuUgpx7Xcw")]
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    public OriginalPaymentInstruction31? OriginalPaymentInformationAndStatus { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV07.SupplementaryData"/>
    [IsoId("_eYJAAW2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
