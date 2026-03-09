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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcknowledgementV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcknowledgementV03( MessageIdentification1 reqAcknowledgementIdentification,MessageIdentification1 reqAcknowledgedMessageReference )
    {
        AcknowledgementIdentification = reqAcknowledgementIdentification;
        AcknowledgedMessageReference = reqAcknowledgedMessageReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the acknowledgement message.
    /// </summary>
    [IsoId("_hJ9OidE8Ed-BzquC8wXy7w_-2019493414")]
    [DisplayName("Acknowledgement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckId")]
    #endif
    [IsoXmlTag("AckId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 AcknowledgementIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 AcknowledgementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 AcknowledgementIdentification { get; init; } 
    #else
    public MessageIdentification1 AcknowledgementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_hKG_gNE8Ed-BzquC8wXy7w_-2019492484")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SimpleIdentificationInformation? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation? TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_hKG_gdE8Ed-BzquC8wXy7w_-2019493025")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3? EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_hKG_gtE8Ed-BzquC8wXy7w_-2019492904")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionStatus4? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4? TransactionStatus { get; init; } 
    #else
    public TransactionStatus4? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the financial institution that is the sender of the acknowledged message.
    /// </summary>
    [IsoId("_hKG_g9E8Ed-BzquC8wXy7w_-2019492381")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Reference to the identification of the acknowledged message.
    /// </summary>
    [IsoId("_hKG_hNE8Ed-BzquC8wXy7w_-2019493336")]
    [DisplayName("Acknowledged Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckdMsgRef")]
    #endif
    [IsoXmlTag("AckdMsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 AcknowledgedMessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 AcknowledgedMessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 AcknowledgedMessageReference { get; init; } 
    #else
    public MessageIdentification1 AcknowledgedMessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_hKG_hdE8Ed-BzquC8wXy7w_-2019492579")]
    [DisplayName("Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForActn")]
    #endif
    [IsoXmlTag("ReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? RequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? RequestForAction { get; init; } 
    #else
    public PendingActivity2? RequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AcknowledgementV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcknowledgementV03.

