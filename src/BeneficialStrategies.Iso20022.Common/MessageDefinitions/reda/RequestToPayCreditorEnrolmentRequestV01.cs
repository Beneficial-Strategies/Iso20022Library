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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.066.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RequestToPayCreditorEnrolmentRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request the creditor registration in the RTP directory.
/// The message may also be forwarded to any authorised third party, as defined in the local scheme.
/// </summary>
[Description(
    @"The RequestToPayCreditorEnrolmentRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request the creditor registration in the RTP directory. |The message may also be forwarded to any authorised third party, as defined in the local scheme."
)]
[IsoId("_rNNBpeHzEeqbls7Gk4-ckA")]
[DisplayName("Request To Pay Creditor Enrolment Request V")]
public record RequestToPayCreditorEnrolmentRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.066.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayCdtrEnrlmntReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.066.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the creditor enrolment request.
    /// </summary>
    [IsoId("_rNNBp-HzEeqbls7Gk4-ckA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required EnrolmentHeader2 Header { get; init; }

    /// <summary>
    /// Specific attributes of the creditor and service enrolment provided by the creditor for its enrolment.
    /// </summary>
    [IsoId("_rNNBqeHzEeqbls7Gk4-ckA")]
    [DisplayName("Creditor Enrolment")]
    [IsoXmlTag("CdtrEnrlmnt")]
    public required CreditorEnrolment3 CreditorEnrolment { get; init; }

    /// <summary>
    /// Specific attributes requested from the debtor for its activation as specified by the creditor in the creditor enrolment request.
    /// </summary>
    [IsoId("_rNNBq-HzEeqbls7Gk4-ckA")]
    [DisplayName("Activation Data")]
    [IsoXmlTag("ActvtnData")]
    public required CreditorInvoice3 ActivationData { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBreHzEeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since RequestToPayCreditorEnrolmentRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToPayCreditorEnrolmentRequestV01.
