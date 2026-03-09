// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting calculation results of equity instruments as part of transparency.
/// </summary>
[IsoId("_vqBVsSe2Eei12pGEsJIAeQ")]
[DisplayName("Transparency Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransparencyDataReport17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransparencyDataReport17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransparencyDataReport17( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_v0EplSe2Eei12pGEsJIAeQ")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_v0Eplye2Eei12pGEsJIAeQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification of the equity instrument.
    /// </summary>
    [IsoId("_wJWWACe2Eei12pGEsJIAeQ")]
    [DisplayName("Financial Instrument Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmClssfctn")]
    #endif
    [IsoXmlTag("FinInstrmClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    #else
    public EquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    [IsoId("_v0EpmSe2Eei12pGEsJIAeQ")]
    [DisplayName("Full Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullNm")]
    #endif
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FullName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FullName { get; init; } 
    #else
    public System.String? FullName { get; set; } 
    #endif
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_v0Epmye2Eei12pGEsJIAeQ")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingVenue { get; init; } 
    #else
    public System.String? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Period to which the quantitative data fields relate.
    /// </summary>
    [IsoId("_v0EpnSe2Eei12pGEsJIAeQ")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? ReportingPeriod { get; init; } 
    #else
    public Period4Choice_? ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to say if this ISIN is liquid or not post calculations.
    /// Usage:
    /// When not present, this field should be treated as not applicable.
    /// </summary>
    [IsoId("_v0Epnye2Eei12pGEsJIAeQ")]
    [DisplayName("Liquidity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lqdty")]
    #endif
    [IsoXmlTag("Lqdty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Liquidity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Liquidity { get; init; } 
    #else
    public System.String? Liquidity { get; set; } 
    #endif
    
    /// <summary>
    /// Methodology that has been used to calculate the result.
    /// </summary>
    [IsoId("_v0EpoSe2Eei12pGEsJIAeQ")]
    [DisplayName("Methodology")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mthdlgy")]
    #endif
    [IsoXmlTag("Mthdlgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransparencyMethodology2Code? Methodology { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransparencyMethodology2Code? Methodology { get; init; } 
    #else
    public TransparencyMethodology2Code? Methodology { get; set; } 
    #endif
    
    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    [IsoId("_v0Epoye2Eei12pGEsJIAeQ")]
    [DisplayName("Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttstcs")]
    #endif
    [IsoXmlTag("Sttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticsTransparency3? Statistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsTransparency3? Statistics { get; init; } 
    #else
    public StatisticsTransparency3? Statistics { get; set; } 
    #endif
    
    /// <summary>
    /// Specific market details related to the most relevant market in terms of liquidity.
    /// </summary>
    [IsoId("_v0EppSe2Eei12pGEsJIAeQ")]
    [DisplayName("Relevant Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RlvntMkt")]
    #endif
    [IsoXmlTag("RlvntMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketDetail2? RelevantMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketDetail2? RelevantMarket { get; init; } 
    #else
    public MarketDetail2? RelevantMarket { get; set; } 
    #endif
    
    
    #nullable disable
    
}
