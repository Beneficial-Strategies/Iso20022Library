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
/// This record is an implementation of the tsmt.041.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransactionReport message is sent by the matching application to the requester of a transaction report.
/// This message is used to report on various details of transactions registered in the matching application.
/// Usage
/// The TransactionReport message can be sent by the matching application to report on various details of transactions that the requester of the report asked for. The message is sent in response to a TransactionReportRequest message.
/// </summary>
[Description(@"Scope|The TransactionReport message is sent by the matching application to the requester of a transaction report.|This message is used to report on various details of transactions registered in the matching application.|Usage|The TransactionReport message can be sent by the matching application to report on various details of transactions that the requester of the report asked for. The message is sent in response to a TransactionReportRequest message.")]
[IsoId("_2UxmeNE8Ed-BzquC8wXy7w_-1389761233")]
[DisplayName("Transaction Report V")]
public partial record TransactionReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.041.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03";
    
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
    /// Identifies the report.
    /// </summary>
    [IsoId("_2UxmedE8Ed-BzquC8wXy7w_-1389761119")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the previous message requesting the report.
    /// </summary>
    [IsoId("_2U6wYNE8Ed-BzquC8wXy7w_-1389760800")]
    [DisplayName("Related Message Reference")]
    [IsoXmlTag("RltdMsgRef")]
    public required MessageIdentification1 RelatedMessageReference { get; init; } 
    
    /// <summary>
    /// Detailed description of the items that correspond to the parameters set in the request.
    /// </summary>
    [IsoId("_2U6wYdE8Ed-BzquC8wXy7w_-1389761189")]
    [DisplayName("Reported Items")]
    [IsoXmlTag("RptdItms")]
    public TransactionReportItems3? ReportedItems { get; init; } 
    
    
    #nullable disable
    
}


// Since TransactionReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransactionReportV03.

