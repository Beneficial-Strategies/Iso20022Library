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


namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// This record is an implementation of the admi.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReceiptAcknowledgement message is sent by the transaction administrator to a member of the system and vice versa. It is sent to acknowledge the receipt of one or multiple messages sent previously. The Acknowledgement message is 1) an application receipt acknowledgement and 2) conveys information about the processing of the original message(s). In case of 2) the ReceiptAcknowledgement can be used as a Generic error message, which provides information about the status (e.g. rejection, acceptance) of an instruction.
/// </summary>
[Description(@"The ReceiptAcknowledgement message is sent by the transaction administrator to a member of the system and vice versa. It is sent to acknowledge the receipt of one or multiple messages sent previously. The Acknowledgement message is 1) an application receipt acknowledgement and 2) conveys information about the processing of the original message(s). In case of 2) the ReceiptAcknowledgement can be used as a Generic error message, which provides information about the status (e.g. rejection, acceptance) of an instruction.")]
[IsoId("_4MJ7oZb3Eee4htziCyV8eA")]
[DisplayName("Receipt Acknowledgement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceiptAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RctAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.007.001.01";
    
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
    /// Constructs a ReceiptAcknowledgementV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceiptAcknowledgementV01( MessageHeader10 reqMessageIdentification,ReceiptAcknowledgementReport2 reqReport )
    {
        MessageIdentification = reqMessageIdentification;
        Report = reqReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the identification the message.
    /// </summary>
    [IsoId("_4MJ7o5b3Eee4htziCyV8eA")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader10 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader10 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader10 MessageIdentification { get; init; } 
    #else
    public MessageHeader10 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides report details on the request.
    /// </summary>
    [IsoId("_4MJ7pZb3Eee4htziCyV8eA")]
    [DisplayName("Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rpt")]
    #endif
    [IsoXmlTag("Rpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReceiptAcknowledgementReport2 Report { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReceiptAcknowledgementReport2 Report { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiptAcknowledgementReport2 Report { get; init; } 
    #else
    public ReceiptAcknowledgementReport2 Report { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_4MJ7p5b3Eee4htziCyV8eA")]
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


// Since ReceiptAcknowledgementV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReceiptAcknowledgementV01.

