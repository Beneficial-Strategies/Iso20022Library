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



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.083.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The IntraBalanceMovementCancellationReport message is sent from a settlement infrastructure to an account owner/requestor to provide full details or current status values of the intra-balance movement cancellation request(s), as defined within the query.|
/// The message may also be used to: 
/// - re-send a message previously sent (the sub-function of the message is &quot;Duplicate&quot;) 
/// - provide a third party with a copy of a message for information (the sub-function of the message is &quot;Copy&quot;) 
/// - re-send to a third party a copy of a message for information (the sub-function of the message is &quot;Copy Duplicate&quot;).
/// </summary>
[Description(@"The IntraBalanceMovementCancellationReport message is sent from a settlement infrastructure to an account owner/requestor to provide full details or current status values of the intra-balance movement cancellation request(s), as defined within the query.||The message may also be used to: |- re-send a message previously sent (the sub-function of the message is ""Duplicate"") |- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"") |- re-send to a third party a copy of a message for information (the sub-function of the message is ""Copy Duplicate"").")]
[IsoId("_DLtKYTncEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement Cancellation Report V")]
public partial record IntraBalanceMovementCancellationReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.083.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntCxlRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.083.001.01";
    
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
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtKcTncEem7JZMuWtwtsg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public DocumentIdentification51? Identification { get; init; } 
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_DLtKczncEem7JZMuWtwtsg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; } 
    
    /// <summary>
    /// General characteristics related to the report information.
    /// </summary>
    [IsoId("_DLtKdTncEem7JZMuWtwtsg")]
    [DisplayName("Report General Details")]
    [IsoXmlTag("RptGnlDtls")]
    public required IntraBalanceReport5 ReportGeneralDetails { get; init; } 
    
    /// <summary>
    /// Provides information on report or error resulting from the originating query message.
    /// </summary>
    [IsoId("_DLtKdzncEem7JZMuWtwtsg")]
    [DisplayName("Report Or Error")]
    [IsoXmlTag("RptOrErr")]
    public IntraBalanceOrOperationalError9Choice_? ReportOrError { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtKeTncEem7JZMuWtwtsg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since IntraBalanceMovementCancellationReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementCancellationReportV01.

