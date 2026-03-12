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
/// This record is an implementation of the tsmt.053.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message InvoicePaymentReconciliationAdvice is sent by a payer to a payee to indicate attribution of payments to instalment of payment obligations in order to simplify the account netting or clearing when a lot of invoices are paid with a unique payment (for instance an SCT or an SDD).
/// The message contains references to payment instructions, may reference other messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The message InvoicePaymentReconciliationAdvice is sent by a payer to a payee to indicate attribution of payments to instalment of payment obligations in order to simplify the account netting or clearing when a lot of invoices are paid with a unique payment (for instance an SCT or an SDD).|The message contains references to payment instructions, may reference other messages and may include referenced data.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDc3-AOSNFX-8224506")]
[DisplayName("Invoice Payment Reconciliation Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoicePaymentReconciliationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.053.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcPmtRcncltnAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.053.001.01";
    
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
    /// Constructs a InvoicePaymentReconciliationAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoicePaymentReconciliationAdviceV01( BusinessLetter1 reqHeader,ReconciliationList1 reqReconciliationList )
    {
        Header = reqHeader;
        ReconciliationList = reqReconciliationList;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the letter, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDc4-AOSNFX-8224506")]
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
    /// List of payment reconciliation information.
    /// </summary>
    [IsoId("_OTgzNDc5-AOSNFX-8224506")]
    [DisplayName("Reconciliation List")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnList")]
    #endif
    [IsoXmlTag("RcncltnList")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationList1 ReconciliationList { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationList1 ReconciliationList { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationList1 ReconciliationList { get; init; } 
    #else
    public ReconciliationList1 ReconciliationList { get; set; } 
    #endif
    
    /// <summary>
    /// Number of reconciliation lists as control value.
    /// </summary>
    [IsoId("_OTgzNDgw-AOSNFX-8224506")]
    [DisplayName("Reconciliation Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnCnt")]
    #endif
    [IsoXmlTag("RcncltnCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? ReconciliationCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationCount { get; init; } 
    #else
    public System.String? ReconciliationCount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDgx-AOSNFX-8224506")]
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
    [IsoId("OTgzNDgy-AOSNFX-8224506")]
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
    [IsoId("_OTgzNDgz-AOSNFX-8224506")]
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


// Since InvoicePaymentReconciliationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoicePaymentReconciliationAdviceV01.

