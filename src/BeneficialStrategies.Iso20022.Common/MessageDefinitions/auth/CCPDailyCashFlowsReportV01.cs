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
/// This record is an implementation of the auth.060.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPDailyCashFlowsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the operational performance and exposures that occurred in a central counterparty payment system.
/// 
/// </summary>
[Description(@"The CCPDailyCashFlowsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the operational performance and exposures that occurred in a central counterparty payment system.|")]
[IsoId("_-yhDUeUTEem3X-64-NKdqg")]
[DisplayName("CCP Daily Cash Flows Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CCPDailyCashFlowsReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.060.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPDalyCshFlowsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.060.001.01";
    
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
    /// Constructs a CCPDailyCashFlowsReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CCPDailyCashFlowsReportV01( ConcentrationAgent1 reqConcentrationAgent,SettlementAgent1 reqSettlementAgent )
    {
        ConcentrationAgent = reqConcentrationAgent;
        SettlementAgent = reqSettlementAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Deposit taking institution with which a central counterparty has accounts used to concentrate cash funds before or after investment.
    /// </summary>
    [IsoId("_-yhDWeUTEem3X-64-NKdqg")]
    [DisplayName("Concentration Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CncntrtnAgt")]
    #endif
    [IsoXmlTag("CncntrtnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConcentrationAgent1 ConcentrationAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConcentrationAgent1 ConcentrationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConcentrationAgent1 ConcentrationAgent { get; init; } 
    #else
    public ConcentrationAgent1 ConcentrationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent used by a central counterparty to allow for the convenient settlement of obligations between a central counterparty and a clearing member, typically in commercial bank money.
    /// </summary>
    [IsoId("_-yhDW-UTEem3X-64-NKdqg")]
    [DisplayName("Settlement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAgt")]
    #endif
    [IsoXmlTag("SttlmAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementAgent1 SettlementAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementAgent1 SettlementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementAgent1 SettlementAgent { get; init; } 
    #else
    public SettlementAgent1 SettlementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_-yhDXeUTEem3X-64-NKdqg")]
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


// Since CCPDailyCashFlowsReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPDailyCashFlowsReportV01.

