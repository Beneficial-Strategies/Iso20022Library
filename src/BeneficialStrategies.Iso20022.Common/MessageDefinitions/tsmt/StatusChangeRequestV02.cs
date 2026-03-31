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

namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.026.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusChangeRequest message is sent by a party involved in a transaction to the matching application.
/// This message is used to request a change in the status of a transaction.
/// Usage
/// The StatusChangeRequest message can be sent by either party involved in a transaction to the matching application to request a change in the status of a transaction.
/// The matching application will pass on the request by sending a StatusChangeRequestNotification message to the counterparty which can accept or reject the request by sending a SatausChangeRequestAcceptance or StatusChangeRequestRejection message.
/// </summary>
[Description(
    @"Scope|The StatusChangeRequest message is sent by a party involved in a transaction to the matching application.|This message is used to request a change in the status of a transaction.|Usage|The StatusChangeRequest message can be sent by either party involved in a transaction to the matching application to request a change in the status of a transaction.|The matching application will pass on the request by sending a StatusChangeRequestNotification message to the counterparty which can accept or reject the request by sending a SatausChangeRequestAcceptance or StatusChangeRequestRejection message."
)]
[IsoId("_xjvgaNE8Ed-BzquC8wXy7w_-2117703681")]
[DisplayName("Status Change Request V")]
public record StatusChangeRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.026.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_xjvgadE8Ed-BzquC8wXy7w_-2117703678")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_xjvgatE8Ed-BzquC8wXy7w_-2117703649")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_xjvga9E8Ed-BzquC8wXy7w_-2117703588")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }

    /// <summary>
    /// Specifies the baseline status requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_xjvgbNE8Ed-BzquC8wXy7w_-2117703618")]
    [DisplayName("Requested Status")]
    [IsoXmlTag("ReqdSts")]
    public required TransactionStatus3 RequestedStatus { get; init; }

    /// <summary>
    /// Specifies the reason for the request to change status.
    /// </summary>
    [IsoId("_xjvgbdE8Ed-BzquC8wXy7w_-2117703557")]
    [DisplayName("Request Reason")]
    [IsoXmlTag("ReqRsn")]
    public Reason2? RequestReason { get; init; }
}

// Since StatusChangeRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusChangeRequestV02.
