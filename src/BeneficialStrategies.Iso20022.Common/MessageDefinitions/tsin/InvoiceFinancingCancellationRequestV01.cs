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

namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// This record is an implementation of the tsin.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The InvoiceFinancingCancellationRequest message is sent by the Financing Requestor to the Intermediary Agent (relay scenario) or First Agent (direct scenario). It is used to request the cancellation of a previously sent financing request.
/// Usage
/// The InvoiceFinancingCancellationRequest message is used by the Financing Requestor to request the cancellation of a previously sent financing request.
/// It is not possible to send a cancellation request for a single invoice contained in a bulk invoice financing request.
/// The InvoiceFinancingCancellationRequest message contains references (original group identification and original creation date and time) of the original financing request message to which is referred.
/// As for InvoiceFinancingRequest, the message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the First Agent. The First Agent is the account servicer of the Financing Requestor.
/// - In a relay scenario, the message is sent to an Intermediary Agent. The Intermediary Agent forwards the InvoiceFinancingCancellingRequest message to the First Agent.
/// </summary>
[Description(
    @"Scope|The InvoiceFinancingCancellationRequest message is sent by the Financing Requestor to the Intermediary Agent (relay scenario) or First Agent (direct scenario). It is used to request the cancellation of a previously sent financing request.|Usage|The InvoiceFinancingCancellationRequest message is used by the Financing Requestor to request the cancellation of a previously sent financing request.|It is not possible to send a cancellation request for a single invoice contained in a bulk invoice financing request.|The InvoiceFinancingCancellationRequest message contains references (original group identification and original creation date and time) of the original financing request message to which is referred.|As for InvoiceFinancingRequest, the message can be used in a direct or a relay scenario:|- In a direct scenario, the message is sent directly to the First Agent. The First Agent is the account servicer of the Financing Requestor.|- In a relay scenario, the message is sent to an Intermediary Agent. The Intermediary Agent forwards the InvoiceFinancingCancellingRequest message to the First Agent."
)]
[IsoId("_BUjIPn1LEeCF8NjrBemJWQ_-1871971623")]
[DisplayName("Invoice Financing Cancellation Request V")]
public record InvoiceFinancingCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.003.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcFincgCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unique and unambiguous identification of the message.
    /// </summary>
    [IsoId("_BUjIP31LEeCF8NjrBemJWQ_-2121755534")]
    [DisplayName("Cancellation Request Identification")]
    [IsoXmlTag("CxlReqId")]
    public required MessageIdentification1 CancellationRequestIdentification { get; init; }

    /// <summary>
    /// Set of information related to the cancellation request, such as actors involved and identification of the original invoice financing request to which the cancellation request refers.
    /// </summary>
    [IsoId("_BUsSIH1LEeCF8NjrBemJWQ_-1725175047")]
    [DisplayName("Cancellation Request Information")]
    [IsoXmlTag("CxlReqInf")]
    public required CancellationRequestInformation1 CancellationRequestInformation { get; init; }
}

// Since InvoiceFinancingCancellationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceFinancingCancellationRequestV01.
