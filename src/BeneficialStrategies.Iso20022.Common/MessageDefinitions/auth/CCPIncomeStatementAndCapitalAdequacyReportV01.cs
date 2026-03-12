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
/// This record is an implementation of the auth.059.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPIncomeStatementAndCapitalAdequacyReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the financial performance and regulatory capital holdings of the central counterparty.
/// </summary>
[Description(@"The CCPIncomeStatementAndCapitalAdequacyReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the financial performance and regulatory capital holdings of the central counterparty.")]
[IsoId("_DzbYceUUEem3X-64-NKdqg")]
[DisplayName("CCP Income Statement And Capital Adequacy Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CCPIncomeStatementAndCapitalAdequacyReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.059.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPIncmStmtAndCptlAdqcyRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.059.001.01";
    
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
    /// Constructs a CCPIncomeStatementAndCapitalAdequacyReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CCPIncomeStatementAndCapitalAdequacyReportV01( IncomeStatement1 reqIncomeStatement,CapitalRequirement1 reqCapitalRequirements,ActiveCurrencyAndAmount reqTotalCapital,ActiveCurrencyAndAmount reqLiquidFinancialResources,HypotheticalCapitalMeasure1 reqHypotheticalCapitalMeasure )
    {
        IncomeStatement = reqIncomeStatement;
        CapitalRequirements = reqCapitalRequirements;
        TotalCapital = reqTotalCapital;
        LiquidFinancialResources = reqLiquidFinancialResources;
        HypotheticalCapitalMeasure = reqHypotheticalCapitalMeasure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Income statement of the CCP.
    /// </summary>
    [IsoId("_DzbYeeUUEem3X-64-NKdqg")]
    [DisplayName("Income Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmStmt")]
    #endif
    [IsoXmlTag("IncmStmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IncomeStatement1 IncomeStatement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IncomeStatement1 IncomeStatement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncomeStatement1 IncomeStatement { get; init; } 
    #else
    public IncomeStatement1 IncomeStatement { get; set; } 
    #endif
    
    /// <summary>
    /// Report of the breakdown of the components for the capital requirement for central counterparty.
    /// </summary>
    [IsoId("_DzbYe-UUEem3X-64-NKdqg")]
    [DisplayName("Capital Requirements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlRqrmnts")]
    #endif
    [IsoXmlTag("CptlRqrmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CapitalRequirement1 CapitalRequirements { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CapitalRequirement1 CapitalRequirements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CapitalRequirement1 CapitalRequirements { get; init; } 
    #else
    public CapitalRequirement1 CapitalRequirements { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the CCP&apos;s capital requirements for operational expenses; for winding down or restructuring its activities; for overall operational and legal risk; for uncovered credit, counterparty credit and market risks and business risks.
    /// </summary>
    [IsoId("_DzbYfeUUEem3X-64-NKdqg")]
    [DisplayName("Total Capital")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCptl")]
    #endif
    [IsoXmlTag("TtlCptl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalCapital { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalCapital { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalCapital { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalCapital { get; set; } 
    #endif
    
    /// <summary>
    /// Total capital resources invested in liquid financial resources.
    /// </summary>
    [IsoId("_DzbYf-UUEem3X-64-NKdqg")]
    [DisplayName("Liquid Financial Resources")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdFinRsrcs")]
    #endif
    [IsoXmlTag("LqdFinRsrcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount LiquidFinancialResources { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount LiquidFinancialResources { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount LiquidFinancialResources { get; init; } 
    #else
    public ActiveCurrencyAndAmount LiquidFinancialResources { get; set; } 
    #endif
    
    /// <summary>
    /// Hypothetical capital requirement due to counterparty credit risk exposures to all clearing members.
    /// </summary>
    [IsoId("_DzbYgeUUEem3X-64-NKdqg")]
    [DisplayName("Hypothetical Capital Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HpthtclCptlMeasr")]
    #endif
    [IsoXmlTag("HpthtclCptlMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required HypotheticalCapitalMeasure1 HypotheticalCapitalMeasure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required HypotheticalCapitalMeasure1 HypotheticalCapitalMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HypotheticalCapitalMeasure1 HypotheticalCapitalMeasure { get; init; } 
    #else
    public HypotheticalCapitalMeasure1 HypotheticalCapitalMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DzbYg-UUEem3X-64-NKdqg")]
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


// Since CCPIncomeStatementAndCapitalAdequacyReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPIncomeStatementAndCapitalAdequacyReportV01.

