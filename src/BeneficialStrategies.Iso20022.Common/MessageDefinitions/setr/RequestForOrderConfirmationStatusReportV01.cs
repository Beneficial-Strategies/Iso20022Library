// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.058.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, send the RequestForOrderConfirmationStatusReport message to the instructing party, for example, an investment manager or its authorised representative, to request the status of one or several order confirmations.
/// Usage
/// The RequestForOrderConfirmationStatusReport message is used to request the status of either:
/// - one or several individual order confirmations, or,
/// - one or several order confirmation messages.
/// The response to a RequestForOrderConfirmationStatusReport message is the OrderConfirmationStatusReport message.
/// When the RequestForOrderConfirmationStatusReport message is used to request the status of several individual order confirmations or one or more order confirmation messages, the executing party may receive several OrderConfirmationStatusReport messages from the instructing party.
/// When the RequestForOrderConfirmationStatusReport is used to request the status of one or more individual order confirmations, each individual order confirmation is identified with its order reference. The message identification of the message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.
/// When the RequestForOrderConfirmationStatusReport is used to request the status of an order confirmation message, then the message identification of the order confirmation message is identified in PreviousReference.
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, send the RequestForOrderConfirmationStatusReport message to the instructing party, for example, an investment manager or its authorised representative, to request the status of one or several order confirmations.|Usage|The RequestForOrderConfirmationStatusReport message is used to request the status of either:|- one or several individual order confirmations, or,|- one or several order confirmation messages.|The response to a RequestForOrderConfirmationStatusReport message is the OrderConfirmationStatusReport message.|When the RequestForOrderConfirmationStatusReport message is used to request the status of several individual order confirmations or one or more order confirmation messages, the executing party may receive several OrderConfirmationStatusReport messages from the instructing party.|When the RequestForOrderConfirmationStatusReport is used to request the status of one or more individual order confirmations, each individual order confirmation is identified with its order reference. The message identification of the message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.|When the RequestForOrderConfirmationStatusReport is used to request the status of an order confirmation message, then the message identification of the order confirmation message is identified in PreviousReference.")]
[IsoId("_v7tBCNE7Ed-BzquC8wXy7w_-862773278")]
[DisplayName("Request For Order Confirmation Status Report V")]
public partial record RequestForOrderConfirmationStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.058.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForOrdrConfStsRptV01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.058.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_v72yANE7Ed-BzquC8wXy7w_1937667668")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Information to identify the order confirmation for which the status is requested.
    /// </summary>
    [IsoId("_v72yAdE7Ed-BzquC8wXy7w_-374664944")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required MessageAndBusinessReference5 RequestDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_v72yAtE7Ed-BzquC8wXy7w_-2086704739")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestForOrderConfirmationStatusReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForOrderConfirmationStatusReportV01.

