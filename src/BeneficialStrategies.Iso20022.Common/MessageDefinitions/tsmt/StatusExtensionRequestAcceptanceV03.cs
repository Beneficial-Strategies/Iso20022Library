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
/// This record is an implementation of the tsmt.031.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusExtensionRequestAcceptance message is sent by the party requested to accept or reject a request to extend the status of a transaction to the matching application.
/// This message is used to inform about the acceptance of a request to extend the status of a transaction.
/// Usage
/// The StatusExtensionRequestAcceptance message can be sent by the party requested to accept or reject the request to extend the status of a transaction to inform that it accepts the request.
/// The message can be sent in response to a StatusExtensionRequestNotification message.
/// The rejection of a request to extend the status of a transaction can be achieved by sending a StatusExtensionRequestRejection message.
/// </summary>
[Description(@"Scope|The StatusExtensionRequestAcceptance message is sent by the party requested to accept or reject a request to extend the status of a transaction to the matching application.|This message is used to inform about the acceptance of a request to extend the status of a transaction.|Usage|The StatusExtensionRequestAcceptance message can be sent by the party requested to accept or reject the request to extend the status of a transaction to inform that it accepts the request.|The message can be sent in response to a StatusExtensionRequestNotification message.|The rejection of a request to extend the status of a transaction can be achieved by sending a StatusExtensionRequestRejection message.")]
[IsoId("_y25KUNE8Ed-BzquC8wXy7w_844950216")]
[DisplayName("Status Extension Request Acceptance V")]
public partial record StatusExtensionRequestAcceptanceV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.031.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnReqAccptnc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.031.001.03";
    
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
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_y25KUdE8Ed-BzquC8wXy7w_844950227")]
    [DisplayName("Acceptance Identification")]
    [IsoXmlTag("AccptncId")]
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_y25KUtE8Ed-BzquC8wXy7w_844950247")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_y25KU9E8Ed-BzquC8wXy7w_844950309")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    
    /// <summary>
    /// Identifies the status for which the user accepts an extension of the validity period.
    /// </summary>
    [IsoId("_y25KVNE8Ed-BzquC8wXy7w_844950278")]
    [DisplayName("Extended Status")]
    [IsoXmlTag("XtndedSts")]
    public required TransactionStatus4 ExtendedStatus { get; init; } 
    
    
    #nullable disable
    
}


// Since StatusExtensionRequestAcceptanceV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusExtensionRequestAcceptanceV03.

