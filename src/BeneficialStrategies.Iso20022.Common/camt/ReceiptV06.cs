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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.025.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Receipt message is sent by the transaction administrator to a member of the system. It is sent to acknowledge the receipt of one or multiple messages sent previously.
/// The Receipt message is an application receipt acknowledgement and conveys information about the processing of the original message(s).
/// Usage
/// The Receipt message is used when the exchange of messages takes place in an asynchronous manner.
/// This may happen, for instance, when an action is requested from the transaction administrator (a deletion, modification or cancellation). The transaction administrator will first acknowledge the request (with a Receipt message) and then execute it.
/// The message can contain information based on the following elements: reference of the message(s) it acknowledges, the status code (optional) and further explanation:
/// - reference of the message it acknowledges
/// - potentially, a status code and an explanation.
/// </summary>
[Description(@"Scope|The Receipt message is sent by the transaction administrator to a member of the system. It is sent to acknowledge the receipt of one or multiple messages sent previously.|The Receipt message is an application receipt acknowledgement and conveys information about the processing of the original message(s).|Usage|The Receipt message is used when the exchange of messages takes place in an asynchronous manner.|This may happen, for instance, when an action is requested from the transaction administrator (a deletion, modification or cancellation). The transaction administrator will first acknowledge the request (with a Receipt message) and then execute it.|The message can contain information based on the following elements: reference of the message(s) it acknowledges, the status code (optional) and further explanation:|- reference of the message it acknowledges|- potentially, a status code and an explanation.")]
[IsoId("_jx5UwwKxEe2rHs6fbn9-0A")]
[DisplayName("Receipt V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceiptV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.025.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "Rct";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.025.001.06";
    
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
    /// Constructs a ReceiptV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceiptV06( MessageHeader9 reqMessageHeader,Receipt4 reqReceiptDetails )
    {
        MessageHeader = reqMessageHeader;
        ReceiptDetails = reqReceiptDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jx5UywKxEe2rHs6fbn9-0A")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader9 MessageHeader { get; init; } 
    #else
    public MessageHeader9 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the receipt.
    /// </summary>
    [IsoId("_jx5UzQKxEe2rHs6fbn9-0A")]
    [DisplayName("Receipt Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctDtls")]
    #endif
    [IsoXmlTag("RctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Receipt4 ReceiptDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Receipt4 ReceiptDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Receipt4 ReceiptDetails { get; init; } 
    #else
    public Receipt4 ReceiptDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jx5UzwKxEe2rHs6fbn9-0A")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ReceiptV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReceiptV06.

