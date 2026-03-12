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



namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// This record is an implementation of the tsin.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The message InvoiceAssignmentStatus is sent by a factoring service provider to a factoring client and, optionally, to an interested party as a response to assignments requests.
/// The factoring service provider returns a copy of items of corresponding requests together with an information about the status of treatment, for example acceptance, rejection or treatment not yet finished. A rejection can be the result of bad message syntax, but also for other motives such as risk, compliance or covenants.
/// For each reported financial item, the factoring service provider includes a reference to the corresponding item of the InvoiceFinancingRequest message and may include the referenced item as well as data from other related and referenced messages.
/// The message contains information about other parties to be notified and whether these parties are required to acknowledge the assignment.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The message InvoiceAssignmentStatus is sent by a factoring service provider to a factoring client and, optionally, to an interested party as a response to assignments requests.|The factoring service provider returns a copy of items of corresponding requests together with an information about the status of treatment, for example acceptance, rejection or treatment not yet finished. A rejection can be the result of bad message syntax, but also for other motives such as risk, compliance or covenants.|For each reported financial item, the factoring service provider includes a reference to the corresponding item of the InvoiceFinancingRequest message and may include the referenced item as well as data from other related and referenced messages.|The message contains information about other parties to be notified and whether these parties are required to acknowledge the assignment.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDQ5-AOSNFX-8224505")]
[DisplayName("Invoice Assignment Status V")]
public partial record InvoiceAssignmentStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcAssgnmtSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.007.001.01";
    
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
    /// Set of characteristics that unambiguously identify the assignment status, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDUw-AOSNFX-8224505")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; } 
    
    /// <summary>
    /// List of assignments of financial items.
    /// </summary>
    [IsoId("_OTgzNDUx-AOSNFX-8224505")]
    [DisplayName("Assignment List")]
    [IsoXmlTag("AssgnmtList")]
    public required FinancingItemList1 AssignmentList { get; init; } 
    
    /// <summary>
    /// Number of assignments.
    /// </summary>
    [IsoId("_OTgzNDUy-AOSNFX-8224505")]
    [DisplayName("Assignment Count")]
    [IsoXmlTag("AssgnmtCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? AssignmentCount { get; init; } 
    
    /// <summary>
    /// Total number of individual items in all assignments.
    /// </summary>
    [IsoId("_OTgzNDUz-AOSNFX-8224505")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDU0-AOSNFX-8224505")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDU1-AOSNFX-8224505")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    
    
    #nullable disable
    
}


// Since InvoiceAssignmentStatusV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceAssignmentStatusV01.

