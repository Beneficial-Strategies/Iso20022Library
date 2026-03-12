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
/// This record is an implementation of the tsin.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The InvoiceAssignmentAcknowledgement message is sent from a trade partner to communicate the status of payment obligations related to financial items. The message can be sent independently or as a response to an InvoiceAssignmentNotification message.
/// Depending on legal contexts the message may be required as a response to an InvoiceAssignmentNotification message in order for the assignment to become effective.
/// The trade party may include references to the corresponding items of an InvoiceAssignmentRequest, InvoiceAssignmentStatus or InvoiceAssignmentNotification or other messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The InvoiceAssignmentAcknowledgement message is sent from a trade partner to communicate the status of payment obligations related to financial items. The message can be sent independently or as a response to an InvoiceAssignmentNotification message.|Depending on legal contexts the message may be required as a response to an InvoiceAssignmentNotification message in order for the assignment to become effective.|The trade party may include references to the corresponding items of an InvoiceAssignmentRequest, InvoiceAssignmentStatus or InvoiceAssignmentNotification or other messages and may include referenced data.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDk4-AOSNFX-8224507")]
[DisplayName("Invoice Assignment Acknowledgement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceAssignmentAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.013.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcAssgnmtAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.013.001.01";
    
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
    /// Constructs a InvoiceAssignmentAcknowledgementV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceAssignmentAcknowledgementV01( BusinessLetter1 reqHeader,FinancingItemList1 reqPaymentStatusList )
    {
        Header = reqHeader;
        PaymentStatusList = reqPaymentStatusList;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the status, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDk5-AOSNFX-8224507")]
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
    /// List of payment status information.
    /// </summary>
    [IsoId("_OTgzNTAw-AOSNFX-8224507")]
    [DisplayName("Payment Status List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtStsList")]
    #endif
    [IsoXmlTag("PmtStsList")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancingItemList1 PaymentStatusList { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancingItemList1 PaymentStatusList { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingItemList1 PaymentStatusList { get; init; } 
    #else
    public FinancingItemList1 PaymentStatusList { get; set; } 
    #endif
    
    /// <summary>
    /// Number of payment information lists as control value.
    /// </summary>
    [IsoId("_OTgzNTAx-AOSNFX-8224507")]
    [DisplayName("Payment Status Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtStsCnt")]
    #endif
    [IsoXmlTag("PmtStsCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? PaymentStatusCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentStatusCount { get; init; } 
    #else
    public System.String? PaymentStatusCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNTAy-AOSNFX-8224507")]
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
    [IsoId("_OTgzNTAz-AOSNFX-8224507")]
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
    [IsoId("_OTgzNTA0-AOSNFX-8224507")]
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


// Since InvoiceAssignmentAcknowledgementV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceAssignmentAcknowledgementV01.

