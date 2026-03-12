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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.016.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralAndExposureReport message is sent:
/// - either by the collateral giver, or its collateral manager, to the collateral taker, or its collateral manager, or
/// - or by the collateral taker, or its collateral manager to the collateral giver, or its collateral manager
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The CollateralAndExposureReport is used to provide the details of the valuation of the collateral, that is, the valuation of securities collateral, cash collateral or other type of collateral, posted at a specific calculation date.
/// </summary>
[Description(@"Scope|The CollateralAndExposureReport message is sent:|- either by the collateral giver, or its collateral manager, to the collateral taker, or its collateral manager, or|- or by the collateral taker, or its collateral manager to the collateral giver, or its collateral manager||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralAndExposureReport is used to provide the details of the valuation of the collateral, that is, the valuation of securities collateral, cash collateral or other type of collateral, posted at a specific calculation date.")]
[IsoId("_XAW1sYFrEeWtPe6Crjmeug")]
[DisplayName("Collateral And Exposure Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAndExposureReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.016.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollAndXpsrRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.016.001.03";
    
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
    /// Constructs a CollateralAndExposureReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralAndExposureReportV03( ReportParameters5 reqReportParameters,Obligation4 reqObligation,Collateral13 reqCollateralReport )
    {
        ReportParameters = reqReportParameters;
        Obligation = reqObligation;
        CollateralReport = reqCollateralReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the report such as the report identification, the report date and time or the report frequency.
    /// </summary>
    [IsoId("_XAW1s4FrEeWtPe6Crjmeug")]
    [DisplayName("Report Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptParams")]
    #endif
    [IsoXmlTag("RptParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportParameters5 ReportParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportParameters5 ReportParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportParameters5 ReportParameters { get; init; } 
    #else
    public ReportParameters5 ReportParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the page number and an indicator of whether it is the only or last page, or if there are additional pages. 
    /// </summary>
    [IsoId("_XAW1tYFrEeWtPe6Crjmeug")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? Pagination { get; init; } 
    #else
    public Pagination? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_XAW1t4FrEeWtPe6Crjmeug")]
    [DisplayName("Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgtn")]
    #endif
    [IsoXmlTag("Oblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation4 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Obligation4 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation4 Obligation { get; init; } 
    #else
    public Obligation4 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_XAW1uYFrEeWtPe6Crjmeug")]
    [DisplayName("Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agrmt")]
    #endif
    [IsoXmlTag("Agrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement4? Agreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement4? Agreement { get; init; } 
    #else
    public Agreement4? Agreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the collateral report.
    /// </summary>
    [IsoId("_XAW1u4FrEeWtPe6Crjmeug")]
    [DisplayName("Collateral Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollRpt")]
    #endif
    [IsoXmlTag("CollRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Collateral13 CollateralReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Collateral13 CollateralReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Collateral13 CollateralReport { get; init; } 
    #else
    public Collateral13 CollateralReport { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_XAW1vYFrEeWtPe6Crjmeug")]
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


// Since CollateralAndExposureReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralAndExposureReportV03.

