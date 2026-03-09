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
/// This record is an implementation of the auth.057.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPPortfolioStressTestingDefinitionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty defines stress scenarios used to stress clearing member portfolios.
/// </summary>
[Description(@"The CCPPortfolioStressTestingDefinitionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty defines stress scenarios used to stress clearing member portfolios.")]
[IsoId("_kjFskeUUEem3X-64-NKdqg")]
[DisplayName("CCP Portfolio Stress Testing Definition Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CCPPortfolioStressTestingDefinitionReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.057.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPPrtflStrssTstgDefRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.057.001.01";
    
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
    /// Constructs a CCPPortfolioStressTestingDefinitionReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CCPPortfolioStressTestingDefinitionReportV01( ScenarioDefinition1 reqScenarioDefinition )
    {
        ScenarioDefinition = reqScenarioDefinition;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains high level data on a stress scenario being applied to portfolios in order to calculate stress losses.
    /// </summary>
    [IsoId("_kjFsmeUUEem3X-64-NKdqg")]
    [DisplayName("Scenario Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScnroDef")]
    #endif
    [IsoXmlTag("ScnroDef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ScenarioDefinition1 ScenarioDefinition { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ScenarioDefinition1 ScenarioDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ScenarioDefinition1 ScenarioDefinition { get; init; } 
    #else
    public ScenarioDefinition1 ScenarioDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kjFsm-UUEem3X-64-NKdqg")]
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


// Since CCPPortfolioStressTestingDefinitionReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPPortfolioStressTestingDefinitionReportV01.

