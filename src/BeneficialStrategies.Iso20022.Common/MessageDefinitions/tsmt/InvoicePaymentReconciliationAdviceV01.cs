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
/// This record is an implementation of the tsmt.053.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message InvoicePaymentReconciliationAdvice is sent by a payer to a payee to indicate attribution of payments to instalment of payment obligations in order to simplify the account netting or clearing when a lot of invoices are paid with a unique payment (for instance an SCT or an SDD).
/// The message contains references to payment instructions, may reference other messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The message InvoicePaymentReconciliationAdvice is sent by a payer to a payee to indicate attribution of payments to instalment of payment obligations in order to simplify the account netting or clearing when a lot of invoices are paid with a unique payment (for instance an SCT or an SDD).|The message contains references to payment instructions, may reference other messages and may include referenced data.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDc3-AOSNFX-8224506")]
[DisplayName("Invoice Payment Reconciliation Advice V")]
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
    
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the letter, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDc4-AOSNFX-8224506")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; } 
    
    /// <summary>
    /// List of payment reconciliation information.
    /// </summary>
    [IsoId("_OTgzNDc5-AOSNFX-8224506")]
    [DisplayName("Reconciliation List")]
    [IsoXmlTag("RcncltnList")]
    public required ReconciliationList1 ReconciliationList { get; init; } 
    
    /// <summary>
    /// Number of reconciliation lists as control value.
    /// </summary>
    [IsoId("_OTgzNDgw-AOSNFX-8224506")]
    [DisplayName("Reconciliation Count")]
    [IsoXmlTag("RcncltnCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ReconciliationCount { get; init; } 
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDgx-AOSNFX-8224506")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("OTgzNDgy-AOSNFX-8224506")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDgz-AOSNFX-8224506")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    
    
    #nullable disable
    
}


// Since InvoicePaymentReconciliationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoicePaymentReconciliationAdviceV01.

