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



namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.001.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Acknowledgement message is sent by the matching application to the party from which it received a message.
/// This message is used to acknowledge the receipt of a message by the matching application.
/// Usage
/// The Acknowledgement message can be sent to a party from which the matching application received a message to acknowledge the receipt of that message. The message is sent when the matching application does not send any other message in response to a received message.
/// </summary>
[Description(@"Scope|The Acknowledgement message is sent by the matching application to the party from which it received a message.|This message is used to acknowledge the receipt of a message by the matching application.|Usage|The Acknowledgement message can be sent to a party from which the matching application received a message to acknowledge the receipt of that message. The message is sent when the matching application does not send any other message in response to a received message.")]
[IsoId("_hJ9OiNE8Ed-BzquC8wXy7w_-2019493432")]
[DisplayName("Acknowledgement V")]
public partial record AcknowledgementV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.001.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "Ack";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.001.001.03";
    
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
    /// Identifies the acknowledgement message.
    /// </summary>
    [IsoId("_hJ9OidE8Ed-BzquC8wXy7w_-2019493414")]
    [DisplayName("Acknowledgement Identification")]
    [IsoXmlTag("AckId")]
    public required MessageIdentification1 AcknowledgementIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_hKG_gNE8Ed-BzquC8wXy7w_-2019492484")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public SimpleIdentificationInformation? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_hKG_gdE8Ed-BzquC8wXy7w_-2019493025")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_hKG_gtE8Ed-BzquC8wXy7w_-2019492904")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionStatus4? TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for the financial institution that is the sender of the acknowledged message.
    /// </summary>
    [IsoId("_hKG_g9E8Ed-BzquC8wXy7w_-2019492381")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Reference to the identification of the acknowledged message.
    /// </summary>
    [IsoId("_hKG_hNE8Ed-BzquC8wXy7w_-2019493336")]
    [DisplayName("Acknowledged Message Reference")]
    [IsoXmlTag("AckdMsgRef")]
    public required MessageIdentification1 AcknowledgedMessageReference { get; init; } 
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_hKG_hdE8Ed-BzquC8wXy7w_-2019492579")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since AcknowledgementV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcknowledgementV03.

