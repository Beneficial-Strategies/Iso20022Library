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
/// This record is an implementation of the tsmt.035.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusExtensionRequest message is sent by either party involved in a transaction to the matching application.
/// This message is used to request the extension of the status of a transaction.
/// Usage
/// The StatusExtensionRequest message can be sent by either party involved in a transaction to the matching application to request the extension of the status of a transaction.
/// The matching application will pass on the request by sending a StatusExtensionRequestNotification message to the counterparty which can accept or reject the status extension request by sending a StatusExtensionAcceptance or StatusExtensionRejection message.
/// </summary>
[Description(@"Scope|The StatusExtensionRequest message is sent by either party involved in a transaction to the matching application.|This message is used to request the extension of the status of a transaction.|Usage|The StatusExtensionRequest message can be sent by either party involved in a transaction to the matching application to request the extension of the status of a transaction.|The matching application will pass on the request by sending a StatusExtensionRequestNotification message to the counterparty which can accept or reject the status extension request by sending a StatusExtensionAcceptance or StatusExtensionRejection message.")]
[IsoId("_0MRo6NE8Ed-BzquC8wXy7w_2103710287")]
[DisplayName("Status Extension Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusExtensionRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.035.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03";
    
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
    /// Constructs a StatusExtensionRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusExtensionRequestV03( MessageIdentification1 reqRequestIdentification,SimpleIdentificationInformation reqTransactionIdentification,TransactionStatus5 reqStatusToBeExtended )
    {
        RequestIdentification = reqRequestIdentification;
        TransactionIdentification = reqTransactionIdentification;
        StatusToBeExtended = reqStatusToBeExtended;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_0MRo6dE8Ed-BzquC8wXy7w_2103710297")]
    [DisplayName("Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqId")]
    #endif
    [IsoXmlTag("ReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RequestIdentification { get; init; } 
    #else
    public MessageIdentification1 RequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_0MRo6tE8Ed-BzquC8wXy7w_2103710318")]
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
    [IsoId("_0MRo69E8Ed-BzquC8wXy7w_2103710380")]
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
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_0MRo7NE8Ed-BzquC8wXy7w_2103710350")]
    [DisplayName("Status To Be Extended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsToBeXtnded")]
    #endif
    [IsoXmlTag("StsToBeXtnded")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus5 StatusToBeExtended { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus5 StatusToBeExtended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus5 StatusToBeExtended { get; init; } 
    #else
    public TransactionStatus5 StatusToBeExtended { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since StatusExtensionRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusExtensionRequestV03.

