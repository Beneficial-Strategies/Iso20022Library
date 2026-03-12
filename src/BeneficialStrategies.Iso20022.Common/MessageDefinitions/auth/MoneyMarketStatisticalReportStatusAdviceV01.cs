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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.028.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketStatisticalReportStatusAdvice message is sent by the relevant competent authority to the reporting agents to provide the status on the reported transactions.
/// </summary>
[Description(@"The MoneyMarketStatisticalReportStatusAdvice message is sent by the relevant competent authority to the reporting agents to provide the status on the reported transactions.")]
[IsoId("_1P-hEaieEeWHO_l3hf2rlA")]
[DisplayName("Money Market Statistical Report Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MoneyMarketStatisticalReportStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MoneyMarketStatisticalReportStatusAdviceV01( MoneyMarketStatusReportHeader1 reqStatusReportHeader )
    {
        StatusReportHeader = reqStatusReportHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the status on the global report.
    /// </summary>
    [IsoId("_1P-hE6ieEeWHO_l3hf2rlA")]
    [DisplayName("Status Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRptHdr")]
    #endif
    [IsoXmlTag("StsRptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MoneyMarketStatusReportHeader1 StatusReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MoneyMarketStatusReportHeader1 StatusReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyMarketStatusReportHeader1 StatusReportHeader { get; init; } 
    #else
    public MoneyMarketStatusReportHeader1 StatusReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status on an individual transaction and the related reason if required.
    /// </summary>
    [IsoId("_1P-hFaieEeWHO_l3hf2rlA")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MoneyMarketTransactionStatus2? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyMarketTransactionStatus2? TransactionStatus { get; init; } 
    #else
    public MoneyMarketTransactionStatus2? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1P-hF6ieEeWHO_l3hf2rlA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MoneyMarketStatisticalReportStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MoneyMarketStatisticalReportStatusAdviceV01.

