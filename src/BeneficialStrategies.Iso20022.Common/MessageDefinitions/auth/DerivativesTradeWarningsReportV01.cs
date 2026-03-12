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
/// This record is an implementation of the auth.106.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeWarningsReport is sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.
/// </summary>
[Description(@"The DerivativesTradeWarningsReport is sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.")]
[IsoId("_pVW9r2mFEe2DRvVJM2Qy-g")]
[DisplayName("Derivatives Trade Warnings Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativesTradeWarningsReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.106.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradWrnngsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.106.001.01";
    
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
    /// Constructs a DerivativesTradeWarningsReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativesTradeWarningsReportV01( StatisticsPerCounterparty16Choice_ reqWarningsStatistics )
    {
        WarningsStatistics = reqWarningsStatistics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed information on missing valuations of outstanding derivatives, missing margin information of outstanding derivatives, as well as on abnormal values reported in the fields.
    /// </summary>
    [IsoId("_pVW9sWmFEe2DRvVJM2Qy-g")]
    [DisplayName("Warnings Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WrnngsSttstcs")]
    #endif
    [IsoXmlTag("WrnngsSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerCounterparty16Choice_ WarningsStatistics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticsPerCounterparty16Choice_ WarningsStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerCounterparty16Choice_ WarningsStatistics { get; init; } 
    #else
    public StatisticsPerCounterparty16Choice_ WarningsStatistics { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVW9s2mFEe2DRvVJM2Qy-g")]
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


// Since DerivativesTradeWarningsReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DerivativesTradeWarningsReportV01.

