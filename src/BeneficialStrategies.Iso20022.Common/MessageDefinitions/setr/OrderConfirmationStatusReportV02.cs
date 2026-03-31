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

namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.057.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The OrderConfirmationStatusReport message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.
/// Usage
/// The OrderConfirmationStatusReport message is used to report on the status of one or more individual:
/// - subscription confirmations,
/// - subscription confirmation amendments,
/// - redemption confirmations,
/// - redemption confirmation amendments,
/// - switch order confirmations,
/// - switch order confirmation amendments.
/// One of the following statuses can be reported:
/// - confirmation rejected, or,
/// - amendment rejected, or,
/// - sent to next party, or,
/// - communication problem with next party, or,
/// - confirmation accepted, or,
/// - confirmation received.
/// It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.
/// If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.
/// The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended.
/// </summary>
[Description(
    @"Scope|The OrderConfirmationStatusReport message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to report the status of an order confirmation or an order confirmation amendment.|Usage|The OrderConfirmationStatusReport message is used to report on the status of one or more individual:|- subscription confirmations,|- subscription confirmation amendments,|- redemption confirmations,|- redemption confirmation amendments,|- switch order confirmations,|- switch order confirmation amendments.|One of the following statuses can be reported:|- confirmation rejected, or,|- amendment rejected, or,|- sent to next party, or,|- communication problem with next party, or,|- confirmation accepted, or,|- confirmation received.|It is likely that the OrderConfirmationStatusReport is only sent by the order instructing party to the order executing party to reject an order confirmation or to reject an order confirmation amendment, although if an intermediary party is used, the statuses sent to next party and communication problem with next party are also likely be used. The statuses confirmation accepted and confirmation received would only be used in the event the order executing party sends a RequestForOrderConfirmationStatusReport message and one of the other statuses does not apply.|If the status being reported is either confirmation rejected or amendment rejected, then a reason for the rejection must be given.|The individual order confirmation or confirmation amendment for which the status is given is identified with its order reference. The message identification of the message in which the individual order confirmation or confirmation amendment was conveyed may also be quoted in RelatedReference, but this is not recommended."
)]
[IsoId("_Aab8NTbLEead9bDRE_1DAQ")]
[DisplayName("Order Confirmation Status Report V")]
public record OrderConfirmationStatusReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.057.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "OrdrConfStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.057.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab8PTbLEead9bDRE_1DAQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_JkdC0EhAEea8pJjypp-yMQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References61Choice_? Reference { get; init; }

    /// <summary>
    /// Status report details of an individual order confirmation.
    /// </summary>
    [IsoId("_Aab8QzbLEead9bDRE_1DAQ")]
    [DisplayName("Individual Order Confirmation Details Report")]
    [IsoXmlTag("IndvOrdrConfDtlsRpt")]
    public required IndividualOrderConfirmationStatusAndReason2 IndividualOrderConfirmationDetailsReport { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab8RTbLEead9bDRE_1DAQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since OrderConfirmationStatusReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to OrderConfirmationStatusReportV02.
