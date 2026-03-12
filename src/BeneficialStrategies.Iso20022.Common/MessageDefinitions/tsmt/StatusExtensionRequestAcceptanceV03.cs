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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusExtensionRequestAcceptanceV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusExtensionRequestAcceptanceV03( MessageIdentification1 reqAcceptanceIdentification,SimpleIdentificationInformation reqTransactionIdentification,TransactionStatus4 reqExtendedStatus )
    {
        AcceptanceIdentification = reqAcceptanceIdentification;
        TransactionIdentification = reqTransactionIdentification;
        ExtendedStatus = reqExtendedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_y25KUdE8Ed-BzquC8wXy7w_844950227")]
    [DisplayName("Acceptance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncId")]
    #endif
    [IsoXmlTag("AccptncId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 AcceptanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 AcceptanceIdentification { get; init; } 
    #else
    public MessageIdentification1 AcceptanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_y25KUtE8Ed-BzquC8wXy7w_844950247")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_y25KU9E8Ed-BzquC8wXy7w_844950309")]
    [DisplayName("Submitter Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrTxRef")]
    #endif
    [IsoXmlTag("SubmitrTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #else
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status for which the user accepts an extension of the validity period.
    /// </summary>
    [IsoId("_y25KVNE8Ed-BzquC8wXy7w_844950278")]
    [DisplayName("Extended Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedSts")]
    #endif
    [IsoXmlTag("XtndedSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus4 ExtendedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus4 ExtendedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4 ExtendedStatus { get; init; } 
    #else
    public TransactionStatus4 ExtendedStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since StatusExtensionRequestAcceptanceV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusExtensionRequestAcceptanceV03.

