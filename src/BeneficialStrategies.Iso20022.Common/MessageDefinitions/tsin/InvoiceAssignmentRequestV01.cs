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
/// This record is an implementation of the tsin.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The InvoiceAssignmentRequest message is sent from a factoring client to a factoring service provider and, optionally, to an interested party. It indicates the transfer of payment obligations concerning financial documents.
/// The message contains a list of financing requests together with data that are necessary to transfer the related rights for example regarding legal references for example jurisdiction, language or country. Furthermore, the message can reference related messages and can include data from other messages.
/// A factoring client combines a set of financial documents with same characteristics and assigns them to a factoring service. The client can send several assignments in one message and combine them according to different criteria for example for different clients or different currencies.
/// </summary>
[Description(@"The InvoiceAssignmentRequest message is sent from a factoring client to a factoring service provider and, optionally, to an interested party. It indicates the transfer of payment obligations concerning financial documents.|The message contains a list of financing requests together with data that are necessary to transfer the related rights for example regarding legal references for example jurisdiction, language or country. Furthermore, the message can reference related messages and can include data from other messages.|A factoring client combines a set of financial documents with same characteristics and assigns them to a factoring service. The client can send several assignments in one message and combine them according to different criteria for example for different clients or different currencies.")]
[IsoId("_OTgzNDQy-AOSNFX-8224505")]
[DisplayName("Invoice Assignment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceAssignmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.006.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcAssgnmtReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.006.001.01";
    
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
    /// Constructs a InvoiceAssignmentRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceAssignmentRequestV01( BusinessLetter1 reqHeader,FinancingItemList1 reqAssignmentList )
    {
        Header = reqHeader;
        AssignmentList = reqAssignmentList;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the invoice assigment request, such as group identification, creation date time, number of single invoice financing requests, totals and subtotals.
    /// </summary>
    [IsoId("_OTgzNDQz-AOSNFX-8224505")]
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
    /// List of assignments of financial items.
    /// </summary>
    [IsoId("_OTgzNDQ0-AOSNFX-8224505")]
    [DisplayName("Assignment List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssgnmtList")]
    #endif
    [IsoXmlTag("AssgnmtList")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancingItemList1 AssignmentList { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancingItemList1 AssignmentList { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingItemList1 AssignmentList { get; init; } 
    #else
    public FinancingItemList1 AssignmentList { get; set; } 
    #endif
    
    /// <summary>
    /// Number of assignments.
    /// </summary>
    [IsoId("_OTgzNDQ1-AOSNFX-8224505")]
    [DisplayName("Assignment Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssgnmtCnt")]
    #endif
    [IsoXmlTag("AssgnmtCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? AssignmentCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssignmentCount { get; init; } 
    #else
    public System.String? AssignmentCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of individual items in all assignments.
    /// </summary>
    [IsoId("_OTgzNDQ2-AOSNFX-8224505")]
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
    [IsoId("_OTgzNDQ3-AOSNFX-8224505")]
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
    [IsoId("_OTgzNDQ4-AOSNFX-8224505")]
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


// Since InvoiceAssignmentRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceAssignmentRequestV01.

