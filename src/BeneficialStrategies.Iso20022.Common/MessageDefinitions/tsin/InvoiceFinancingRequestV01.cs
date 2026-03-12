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
/// This record is an implementation of the tsin.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The InvoiceFinancingRequest message is sent by Financing Requestor to the Intermediary Agent or First agent. It is used to request financing of a set of invoices, referenced in the request message itself. If the whole financing request (or a selection of single invoice requests included) is accepted, the amount financed by the First Agent will be credited either to the account specified in the financing request or to another account held by Financing Requestor to First Agent.
/// Usage
/// The InvoiceFinancingRequest message is issued by the Financing Requestor and represents a bulk financing request since it can contain one or more single financing requests, each request related to an invoice.
/// For every invoice it is always possible to identify a supplier and a buyer.
/// The subject playing the role of supplier can be different from the Financing Requestor; in this case the Financing Requestor is allowed to send the request message on behalf of the supplier itself.
/// This caters for example in the scenario of a collection agency initiating all requests on behalf of a large corporate.
/// In instances where an invoice is going to be paid by means of instalments, the Financing Requestor can request financing for one or more instalments related to the invoice payment. In this case, together with the general information related to the invoice, references about instalments to be financed are specified into the request message. The request message must contain information only about the instalments that the Financing Requestor wants to be financed.
/// The InvoiceFinancingRequest message is used to exchange:
/// - One instance of general information related to the invoice financing request;
/// - One instance of information for each single invoice financing request;
/// - Optionally, one instance of information for each single instalment to be financed.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the First Agent. The First Agent is the account servicer of the Financing Requestor;
/// - In a relay scenario, the message is sent to an Intermediary Agent. The Intermediary Agent acts as an access point that will forward the InvoiceFinancingRequest message to the First Agent.
/// </summary>
[Description(@"Scope|The InvoiceFinancingRequest message is sent by Financing Requestor to the Intermediary Agent or First agent. It is used to request financing of a set of invoices, referenced in the request message itself. If the whole financing request (or a selection of single invoice requests included) is accepted, the amount financed by the First Agent will be credited either to the account specified in the financing request or to another account held by Financing Requestor to First Agent.|Usage|The InvoiceFinancingRequest message is issued by the Financing Requestor and represents a bulk financing request since it can contain one or more single financing requests, each request related to an invoice.|For every invoice it is always possible to identify a supplier and a buyer.|The subject playing the role of supplier can be different from the Financing Requestor; in this case the Financing Requestor is allowed to send the request message on behalf of the supplier itself.|This caters for example in the scenario of a collection agency initiating all requests on behalf of a large corporate.|In instances where an invoice is going to be paid by means of instalments, the Financing Requestor can request financing for one or more instalments related to the invoice payment. In this case, together with the general information related to the invoice, references about instalments to be financed are specified into the request message. The request message must contain information only about the instalments that the Financing Requestor wants to be financed.|The InvoiceFinancingRequest message is used to exchange:|- One instance of general information related to the invoice financing request;|- One instance of information for each single invoice financing request;|- Optionally, one instance of information for each single instalment to be financed.|The message can be used in a direct or a relay scenario:|- In a direct scenario, the message is sent directly to the First Agent. The First Agent is the account servicer of the Financing Requestor;|- In a relay scenario, the message is sent to an Intermediary Agent. The Intermediary Agent acts as an access point that will forward the InvoiceFinancingRequest message to the First Agent.")]
[IsoId("_BU2DIH1LEeCF8NjrBemJWQ_-1652041162")]
[DisplayName("Invoice Financing Request V")]
public partial record InvoiceFinancingRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcFincgReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01";
    
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
    /// Specifies a set of characteristics that unambiguously identify the invoice financing request, such as group identification, creation date time, number of single invoice financing requests.
    /// </summary>
    [IsoId("_BU2DIX1LEeCF8NjrBemJWQ_-1652041118")]
    [DisplayName("Request Group Information")]
    [IsoXmlTag("ReqGrpInf")]
    public required RequestGroupInformation1 RequestGroupInformation { get; init; } 
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the single invoice financing request related to the entire invoice or a specific instalment of the invoice settlement, such as actors involved, invoice totals or payment method.
    /// </summary>
    [IsoId("_BU2DIn1LEeCF8NjrBemJWQ_-1651121112")]
    [DisplayName("Invoice Request Information")]
    [IsoXmlTag("InvcReqInf")]
    public required InvoiceRequestInformation1 InvoiceRequestInformation { get; init; } 
    
    
    #nullable disable
    
}


// Since InvoiceFinancingRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceFinancingRequestV01.

