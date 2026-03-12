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
/// This record is an implementation of the tsin.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The InvoiceFinancingRequestStatus message is sent by the First Agent to the Financing Requestor, alternatively through an Intermediary Agent (relay scenario). It is used to inform the Financing Requestor about the positive or negative status of a financing request or a financing cancellation request.
/// Usage
/// The InvoiceFinancingRequestStatus message flows from the First Agent to the Financing Requestor (alternatively through an Intermediary Agent) to provide status information about a request previously sent.
/// Its usage will always be governed by a bilateral agreement between the First Agent and the Financing Requestor.
/// The InvoiceFinancingRequestStatus message can be used two fold:
/// - to provide information about the reception status (eg rejection, acceptance) of a request message. In this case the status message is the result of a technical validation performed by the First Agent on the request message received;
/// - to inform the Financing Requestor about the business status of the financing process initiated. In this case the First Agent can:
/// * communicate that a single financing request has been granted, is pending or has not been granted at all;
/// * inform that a financing cancellation request has been allowed or denied.
/// Note.
/// If the Financing Requestor requests financing for more than one instalment related to the same invoice, the First Agent can decide to finance only some of the instalments. In such case the status message contains details and status of every single instalment (financed, not financed).
/// The message can be used in a direct or in a relay scenario:
/// - In a direct scenario, the message is sent directly by the First Agent to the Financing Requestor;
/// - In a relay scenario, the message is sent first by the First Agent to the Intermediary Agent, who forwards it to the Financing Requestor.
/// The InvoiceFinancingRequestStatus message refers to the original request(s) by means of references and a set of data elements included into the original request.
/// </summary>
[Description(@"Scope|The InvoiceFinancingRequestStatus message is sent by the First Agent to the Financing Requestor, alternatively through an Intermediary Agent (relay scenario). It is used to inform the Financing Requestor about the positive or negative status of a financing request or a financing cancellation request.|Usage|The InvoiceFinancingRequestStatus message flows from the First Agent to the Financing Requestor (alternatively through an Intermediary Agent) to provide status information about a request previously sent.|Its usage will always be governed by a bilateral agreement between the First Agent and the Financing Requestor.|The InvoiceFinancingRequestStatus message can be used two fold:|- to provide information about the reception status (eg rejection, acceptance) of a request message. In this case the status message is the result of a technical validation performed by the First Agent on the request message received;|- to inform the Financing Requestor about the business status of the financing process initiated. In this case the First Agent can:|* communicate that a single financing request has been granted, is pending or has not been granted at all;|* inform that a financing cancellation request has been allowed or denied.|Note.|If the Financing Requestor requests financing for more than one instalment related to the same invoice, the First Agent can decide to finance only some of the instalments. In such case the status message contains details and status of every single instalment (financed, not financed).|The message can be used in a direct or in a relay scenario:|- In a direct scenario, the message is sent directly by the First Agent to the Financing Requestor;|- In a relay scenario, the message is sent first by the First Agent to the Intermediary Agent, who forwards it to the Financing Requestor.|The InvoiceFinancingRequestStatus message refers to the original request(s) by means of references and a set of data elements included into the original request.")]
[IsoId("_BUZXMH1LEeCF8NjrBemJWQ_1543411923")]
[DisplayName("Invoice Financing Request Status V")]
public partial record InvoiceFinancingRequestStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcFincgReqSts";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01";
    
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
    /// General information that unambiguously identify the invoice financing status report, such as status identification, creation date time.
    /// </summary>
    [IsoId("_BUZXMX1LEeCF8NjrBemJWQ_746296789")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    public required MessageIdentification1 StatusIdentification { get; init; } 
    
    /// <summary>
    /// Set of summary information that unambiguously identifies the original invoice financing (or cancellation) request to which the status is referred. The status of the original request is also given in this block.|.
    /// </summary>
    [IsoId("_BUZXMn1LEeCF8NjrBemJWQ_1550684151")]
    [DisplayName("Original Request Information And Status")]
    [IsoXmlTag("OrgnlReqInfAndSts")]
    public required OriginalRequestInformation1 OriginalRequestInformationAndStatus { get; init; } 
    
    /// <summary>
    /// Information concerning the business status of a financing request.
    /// </summary>
    [IsoId("_BUZXM31LEeCF8NjrBemJWQ_740712719")]
    [DisplayName("Financing Information And Status")]
    [IsoXmlTag("FincgInfAndSts")]
    public FinancingInformationAndStatus1? FinancingInformationAndStatus { get; init; } 
    
    
    #nullable disable
    
}


// Since InvoiceFinancingRequestStatusV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceFinancingRequestStatusV01.

