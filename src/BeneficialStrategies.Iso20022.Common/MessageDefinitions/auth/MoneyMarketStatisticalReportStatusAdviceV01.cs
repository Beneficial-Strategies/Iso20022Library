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



namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.028.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketStatisticalReportStatusAdvice message is sent by the relevant competent authority to the reporting agents to provide the status on the reported transactions.
/// </summary>
[Description(@"The MoneyMarketStatisticalReportStatusAdvice message is sent by the relevant competent authority to the reporting agents to provide the status on the reported transactions.")]
[IsoId("_1P-hEaieEeWHO_l3hf2rlA")]
[DisplayName("Money Market Statistical Report Status Advice V")]
public partial record MoneyMarketStatisticalReportStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.028.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktSttstclRptStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.028.001.01";
    
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
    /// Provides the status on the global report.
    /// </summary>
    [IsoId("_1P-hE6ieEeWHO_l3hf2rlA")]
    [DisplayName("Status Report Header")]
    [IsoXmlTag("StsRptHdr")]
    public required MoneyMarketStatusReportHeader1 StatusReportHeader { get; init; } 
    
    /// <summary>
    /// Provides the status on an individual transaction and the related reason if required.
    /// </summary>
    [IsoId("_1P-hFaieEeWHO_l3hf2rlA")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public MoneyMarketTransactionStatus2? TransactionStatus { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1P-hF6ieEeWHO_l3hf2rlA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MoneyMarketStatisticalReportStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MoneyMarketStatisticalReportStatusAdviceV01.

