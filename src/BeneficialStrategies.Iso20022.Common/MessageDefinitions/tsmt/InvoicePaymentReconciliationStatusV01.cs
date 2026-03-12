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
/// This record is an implementation of the tsmt.054.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message InvoicePaymentReconciliationStatus is sent from a payee to a payer to acknowledge attribution of payments.
/// A payee that has received payment reconciliation information uses this message to confirm or to question common understanding of payments and instalments.
/// The payee may include references to the corresponding items of an InvoicePaymentReconciliationAdvice message or to other messages and may include the referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The message InvoicePaymentReconciliationStatus is sent from a payee to a payer to acknowledge attribution of payments.|A payee that has received payment reconciliation information uses this message to confirm or to question common understanding of payments and instalments.|The payee may include references to the corresponding items of an InvoicePaymentReconciliationAdvice message or to other messages and may include the referenced data.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNTA1-AOSNFX-8224507")]
[DisplayName("Invoice Payment Reconciliation Status V")]
public partial record InvoicePaymentReconciliationStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.054.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcPmtRcncltnSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.054.001.01";
    
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
    /// Specifies a set of characteristics that unambiguously identify the status, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNTA2-AOSNFX-8224507")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; } 
    
    /// <summary>
    /// List of payment reconciliation information.
    /// </summary>
    [IsoId("_OTgzNTA3-AOSNFX-822450")]
    [DisplayName("Reconciliation List")]
    [IsoXmlTag("RcncltnList")]
    public required ReconciliationList1 ReconciliationList { get; init; } 
    
    /// <summary>
    /// Specifies the number of reconciliation lists.
    /// </summary>
    [IsoId("_OTgzNTA4-AOSNFX-8224507")]
    [DisplayName("Reconciliation Count")]
    [IsoXmlTag("RcncltnCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ReconciliationCount { get; init; } 
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNTA5-AOSNFX-8224507")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNTEw-AOSNFX-8224507")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNTEx-AOSNFX-8224507")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    
    
    #nullable disable
    
}


// Since InvoicePaymentReconciliationStatusV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoicePaymentReconciliationStatusV01.

