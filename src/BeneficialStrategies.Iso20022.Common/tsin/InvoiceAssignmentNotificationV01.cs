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


namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// This record is an implementation of the tsin.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is sent from a factoring service provider or a factoring client to a trade partner to inform about assignments of financing items and, optionally, to an interested party.
/// The information given to the trade party indicates that property of the payment obligation has been or is being transferred to the financial institution and that payments have to be done between the trade partner and the factoring service provider.
/// The message indicates whether the notified party is required to acknowledge the notified assignment and to which party an acknowledgement has to be sent.
/// This message can also be used outside a factoring context directly between a payer and a payee for example as a reminder about a payment obligation or to make an adjustment.
/// If applicable, the message may reference corresponding items of an InvoiceFinancingRequest or InvoiceFinancingStatus or other related messages and may contain referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"This message is sent from a factoring service provider or a factoring client to a trade partner to inform about assignments of financing items and, optionally, to an interested party.|The information given to the trade party indicates that property of the payment obligation has been or is being transferred to the financial institution and that payments have to be done between the trade partner and the factoring service provider.|The message indicates whether the notified party is required to acknowledge the notified assignment and to which party an acknowledgement has to be sent.|This message can also be used outside a factoring context directly between a payer and a payee for example as a reminder about a payment obligation or to make an adjustment.|If applicable, the message may reference corresponding items of an InvoiceFinancingRequest or InvoiceFinancingStatus or other related messages and may contain referenced data.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDU2-AOSNFX-8224505")]
[DisplayName("Invoice Assignment Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceAssignmentNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.008.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcAssgnmtNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.008.001.01";
    
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
    /// Constructs a InvoiceAssignmentNotificationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceAssignmentNotificationV01( BusinessLetter1 reqHeader,FinancingItemList1 reqNotificationList )
    {
        Header = reqHeader;
        NotificationList = reqNotificationList;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the assignment notification, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDU3-AOSNFX-8224506")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BusinessLetter1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BusinessLetter1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessLetter1 Header { get; init; } 
    #else
    public BusinessLetter1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// List of assignment notifications.
    /// </summary>
    [IsoId("_OTgzNDU4-AOSNFX-8224506")]
    [DisplayName("Notification List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnList")]
    #endif
    [IsoXmlTag("NtfctnList")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancingItemList1 NotificationList { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancingItemList1 NotificationList { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingItemList1 NotificationList { get; init; } 
    #else
    public FinancingItemList1 NotificationList { get; set; } 
    #endif
    
    /// <summary>
    /// Number of assignment notification lists.
    /// </summary>
    [IsoId("_OTgzNDU5-AOSNFX-8224506")]
    [DisplayName("Notification Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnCnt")]
    #endif
    [IsoXmlTag("NtfctnCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NotificationCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NotificationCount { get; init; } 
    #else
    public System.String? NotificationCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDYw-AOSNFX-8224506")]
    [DisplayName("Item Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmCnt")]
    #endif
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? ItemCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ItemCount { get; init; } 
    #else
    public System.String? ItemCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDYx-AOSNFX-8224506")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDYy-AOSNFX-8224506")]
    [DisplayName("Attached Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttchdMsg")]
    #endif
    [IsoXmlTag("AttchdMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    #else
    public EncapsulatedBusinessMessage1? AttachedMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since InvoiceAssignmentNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceAssignmentNotificationV01.

