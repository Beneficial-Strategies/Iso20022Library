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

/// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV05"/>
[Description(
    @"The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file)."
)]
[IsoId("_gO7AUYIWEeWs6fzahhkJjg")]
[DisplayName("Creditor Payment Activation Request Status Report V")]
public partial record CreditorPaymentActivationRequestStatusReportV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.014.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReqStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.014.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV05.GroupHeader"/>
    [IsoId("_gO7AXYIWEeWs6fzahhkJjg")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader46 GroupHeader { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV05.OriginalGroupInformationAndStatus"/>
    [IsoId("_gO7AX4IWEeWs6fzahhkJjg")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public required OriginalGroupInformation25 OriginalGroupInformationAndStatus { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV05.OriginalPaymentInformationAndStatus"/>
    [IsoId("_gO7AYYIWEeWs6fzahhkJjg")]
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    public OriginalPaymentInstruction19? OriginalPaymentInformationAndStatus { get; init; }

    /// <inheritdoc cref="ICreditorPaymentActivationRequestStatusReportV05.SupplementaryData"/>
    [IsoId("_gO7AY4IWEeWs6fzahhkJjg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
