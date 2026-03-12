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
/// This record is an implementation of the tsmt.038.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusReportRequest message is sent by a party involved in a transaction to the matching application.
/// This message is used to request a report on the status of transactions registered in the matching application.
/// Usage
/// The StatusReportRequest message can be sent by either party involved in a transaction to request a report on the status and sub-statuses of all transactions that the requester is involved in.
/// The application will respond to the request by sending a StatusReport message.
/// </summary>
[Description(@"Scope|The StatusReportRequest message is sent by a party involved in a transaction to the matching application.|This message is used to request a report on the status of transactions registered in the matching application.|Usage|The StatusReportRequest message can be sent by either party involved in a transaction to request a report on the status and sub-statuses of all transactions that the requester is involved in.|The application will respond to the request by sending a StatusReport message.")]
[IsoId("_0n_7mNE8Ed-BzquC8wXy7w_-619721878")]
[DisplayName("Status Report Request V")]
public partial record StatusReportRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.038.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsRptReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.038.001.03";
    
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
    /// Identifies the request message.
    /// </summary>
    [IsoId("_0n_7mdE8Ed-BzquC8wXy7w_-619721785")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the entities of the submitter for which the transactions have to be reported.
    /// </summary>
    [IsoId("_0n_7mtE8Ed-BzquC8wXy7w_-619721446")]
    [DisplayName("Entities To Be Reported")]
    [IsoXmlTag("NttiesToBeRptd")]
    public BICIdentification1? EntitiesToBeReported { get; init; } 
    
    
    #nullable disable
    
}


// Since StatusReportRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusReportRequestV03.

