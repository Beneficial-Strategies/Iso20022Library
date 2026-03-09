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
/// This record is an implementation of the auth.064.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPAvailableFinancialResourcesReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the aggregate quantum of resources available in each default waterfall to absorb losses resulting from the failure of one or more clearing member(s).
/// </summary>
[Description(@"The CCPAvailableFinancialResourcesReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the aggregate quantum of resources available in each default waterfall to absorb losses resulting from the failure of one or more clearing member(s).")]
[IsoId("_omGWYeUREem3X-64-NKdqg")]
[DisplayName("CCP Available Financial Resources Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CCPAvailableFinancialResourcesReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.064.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPAvlblFinRsrcsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.064.001.01";
    
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
    /// Constructs a CCPAvailableFinancialResourcesReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CCPAvailableFinancialResourcesReportV01( AvailableFinancialResourcesAmount1 reqAvailableFinancialResourcesAmount )
    {
        AvailableFinancialResourcesAmount = reqAvailableFinancialResourcesAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Construct used by a central counterparty to define the size of the aggregate quantum of resources available from a clearing member.
    /// </summary>
    [IsoId("_omGWaeUREem3X-64-NKdqg")]
    [DisplayName("Available Financial Resources Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblFinRsrcsAmt")]
    #endif
    [IsoXmlTag("AvlblFinRsrcsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AvailableFinancialResourcesAmount1 AvailableFinancialResourcesAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AvailableFinancialResourcesAmount1 AvailableFinancialResourcesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AvailableFinancialResourcesAmount1 AvailableFinancialResourcesAmount { get; init; } 
    #else
    public AvailableFinancialResourcesAmount1 AvailableFinancialResourcesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of other CCP prefunded resources required as part of the default waterfall.
    /// </summary>
    [IsoId("_omGWa-UREem3X-64-NKdqg")]
    [DisplayName("Other Prefunded Resources")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPrfnddRsrcs")]
    #endif
    [IsoXmlTag("OthrPrfnddRsrcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportingAssetBreakdown1? OtherPrefundedResources { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingAssetBreakdown1? OtherPrefundedResources { get; init; } 
    #else
    public ReportingAssetBreakdown1? OtherPrefundedResources { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_omGWbeUREem3X-64-NKdqg")]
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


// Since CCPAvailableFinancialResourcesReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPAvailableFinancialResourcesReportV01.

