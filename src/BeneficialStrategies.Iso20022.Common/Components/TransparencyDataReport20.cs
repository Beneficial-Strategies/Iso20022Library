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
/// Provides for reporting calculation results of non equity instruments as part of transparency.
/// </summary>
[IsoId("_rydgQaaWEeqM19y9ajxjTA")]
[DisplayName("Transparency Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransparencyDataReport20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransparencyDataReport20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransparencyDataReport20( InstrumentOrSubClassIdentification2Choice_ reqIdentification )
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
    [IsoId("_r0GfBaaWEeqM19y9ajxjTA")]
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
    /// Identifies the financial instrument or the class of financial instruments to which the result relates.
    /// </summary>
    [IsoId("_r0GfB6aWEeqM19y9ajxjTA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstrumentOrSubClassIdentification2Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstrumentOrSubClassIdentification2Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstrumentOrSubClassIdentification2Choice_ Identification { get; init; } 
    #else
    public InstrumentOrSubClassIdentification2Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    [IsoId("_r0GfCaaWEeqM19y9ajxjTA")]
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
    [IsoId("_r0GfC6aWEeqM19y9ajxjTA")]
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
    [IsoId("_r0GfDaaWEeqM19y9ajxjTA")]
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
    [IsoId("_r0GfD6aWEeqM19y9ajxjTA")]
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
    /// The pre-trade Large in Scale threshold.
    /// </summary>
    [IsoId("_r0GfEaaWEeqM19y9ajxjTA")]
    [DisplayName("Pre Trade Large In Scale Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreTradLrgInScaleThrshld")]
    #endif
    [IsoXmlTag("PreTradLrgInScaleThrshld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TonsOrCurrency2Choice_? PreTradeLargeInScaleThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TonsOrCurrency2Choice_? PreTradeLargeInScaleThreshold { get; init; } 
    #else
    public TonsOrCurrency2Choice_? PreTradeLargeInScaleThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// The post-trade Large in Scale threshold.
    /// </summary>
    [IsoId("_r0GfE6aWEeqM19y9ajxjTA")]
    [DisplayName("Post Trade Large In Scale Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstTradLrgInScaleThrshld")]
    #endif
    [IsoXmlTag("PstTradLrgInScaleThrshld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TonsOrCurrency2Choice_? PostTradeLargeInScaleThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TonsOrCurrency2Choice_? PostTradeLargeInScaleThreshold { get; init; } 
    #else
    public TonsOrCurrency2Choice_? PostTradeLargeInScaleThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// The pre-trade Size Specific to an Instrument threshold.
    /// </summary>
    [IsoId("_r0GfFaaWEeqM19y9ajxjTA")]
    [DisplayName("Pre Trade Instrument Size Specific Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreTradInstrmSzSpcfcThrshld")]
    #endif
    [IsoXmlTag("PreTradInstrmSzSpcfcThrshld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TonsOrCurrency2Choice_? PreTradeInstrumentSizeSpecificThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TonsOrCurrency2Choice_? PreTradeInstrumentSizeSpecificThreshold { get; init; } 
    #else
    public TonsOrCurrency2Choice_? PreTradeInstrumentSizeSpecificThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// The post-trade Size Specific to an Instrument threshold.
    /// </summary>
    [IsoId("_r0GfF6aWEeqM19y9ajxjTA")]
    [DisplayName("Post Trade Instrument Size Specific Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstTradInstrmSzSpcfcThrshld")]
    #endif
    [IsoXmlTag("PstTradInstrmSzSpcfcThrshld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TonsOrCurrency2Choice_? PostTradeInstrumentSizeSpecificThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TonsOrCurrency2Choice_? PostTradeInstrumentSizeSpecificThreshold { get; init; } 
    #else
    public TonsOrCurrency2Choice_? PostTradeInstrumentSizeSpecificThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    [IsoId("_r0GfGaaWEeqM19y9ajxjTA")]
    [DisplayName("Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttstcs")]
    #endif
    [IsoXmlTag("Sttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatisticsTransparency2? Statistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsTransparency2? Statistics { get; init; } 
    #else
    public StatisticsTransparency2? Statistics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
