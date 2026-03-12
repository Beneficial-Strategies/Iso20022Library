// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting calculation results of non equity instruments as part of transparency.
/// </summary>
[IsoId("_GjQXQSe3Eei12pGEsJIAeQ")]
[DisplayName("Transparency Data Report")]
public partial record TransparencyDataReport18
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_GtMWYye3Eei12pGEsJIAeQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_GtMWZSe3Eei12pGEsJIAeQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; } 
    
    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    [IsoId("_HY_scie3Eei12pGEsJIAeQ")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public NonEquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; } 
    
    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    [IsoId("_GtMWZye3Eei12pGEsJIAeQ")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; } 
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_GtMWaSe3Eei12pGEsJIAeQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; } 
    
    /// <summary>
    /// Period to which the quantitative data fields relate.
    /// </summary>
    [IsoId("_GtMWaye3Eei12pGEsJIAeQ")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Flag to say if this ISIN is liquid or not post calculations.
    /// Usage:
    /// When not present, this field should be treated as not applicable.
    /// </summary>
    [IsoId("_GtMWbSe3Eei12pGEsJIAeQ")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Liquidity { get; init; } 
    
    /// <summary>
    /// The pre-trade Large in Scale threshold.
    /// </summary>
    [IsoId("_GtMWbye3Eei12pGEsJIAeQ")]
    [DisplayName("Pre Trade Large In Scale Threshold")]
    [IsoXmlTag("PreTradLrgInScaleThrshld")]
    public TonsOrCurrency2Choice_? PreTradeLargeInScaleThreshold { get; init; } 
    
    /// <summary>
    /// The post-trade Large in Scale threshold.
    /// </summary>
    [IsoId("_GtMWcSe3Eei12pGEsJIAeQ")]
    [DisplayName("Post Trade Large In Scale Threshold")]
    [IsoXmlTag("PstTradLrgInScaleThrshld")]
    public TonsOrCurrency2Choice_? PostTradeLargeInScaleThreshold { get; init; } 
    
    /// <summary>
    /// The pre-trade Size Specific to an Instrument threshold.
    /// </summary>
    [IsoId("_GtMWcye3Eei12pGEsJIAeQ")]
    [DisplayName("Pre Trade Instrument Size Specific Threshold")]
    [IsoXmlTag("PreTradInstrmSzSpcfcThrshld")]
    public TonsOrCurrency2Choice_? PreTradeInstrumentSizeSpecificThreshold { get; init; } 
    
    /// <summary>
    /// The post-trade Size Specific to an Instrument threshold.
    /// </summary>
    [IsoId("_GtMWdSe3Eei12pGEsJIAeQ")]
    [DisplayName("Post Trade Instrument Size Specific Threshold")]
    [IsoXmlTag("PstTradInstrmSzSpcfcThrshld")]
    public TonsOrCurrency2Choice_? PostTradeInstrumentSizeSpecificThreshold { get; init; } 
    
    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    [IsoId("_GtMWdye3Eei12pGEsJIAeQ")]
    [DisplayName("Statistics")]
    [IsoXmlTag("Sttstcs")]
    public StatisticsTransparency2? Statistics { get; init; } 
    
    
    #nullable disable
    
}
