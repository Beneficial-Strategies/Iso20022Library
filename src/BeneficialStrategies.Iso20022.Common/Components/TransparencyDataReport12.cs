// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting calculation results of equity instruments as part of transparency.
/// </summary>
[IsoId("_1xRg0Wk8EeaLAKoEUNsD9g")]
[DisplayName("Transparency Data Report")]
public partial record TransparencyDataReport12
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_16UvJWk8EeaLAKoEUNsD9g")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_16UvJ2k8EeaLAKoEUNsD9g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; } 
    
    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    [IsoId("_16UvKWk8EeaLAKoEUNsD9g")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; } 
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_16UvK2k8EeaLAKoEUNsD9g")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; } 
    
    /// <summary>
    /// Period to which the quantitative data fields relate.
    /// </summary>
    [IsoId("_16UvLWk8EeaLAKoEUNsD9g")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Flag to say if this ISIN is liquid or not post calculations.
    /// Usage:
    /// When not present, this field should be treated as not applicable.
    /// </summary>
    [IsoId("_16UvL2k8EeaLAKoEUNsD9g")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Liquidity { get; init; } 
    
    /// <summary>
    /// Methodology that has been used to calculate the result.
    /// </summary>
    [IsoId("_16UvMWk8EeaLAKoEUNsD9g")]
    [DisplayName("Methodology")]
    [IsoXmlTag("Mthdlgy")]
    public TransparencyMethodology2Code? Methodology { get; init; } 
    
    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    [IsoId("_16UvM2k8EeaLAKoEUNsD9g")]
    [DisplayName("Statistics")]
    [IsoXmlTag("Sttstcs")]
    public StatisticsTransparency3? Statistics { get; init; } 
    
    /// <summary>
    /// Specific market details related to the most relevant market in terms of liquidity.
    /// </summary>
    [IsoId("_16UvNWk8EeaLAKoEUNsD9g")]
    [DisplayName("Relevant Market")]
    [IsoXmlTag("RlvntMkt")]
    public MarketDetail2? RelevantMarket { get; init; } 
    
    
    #nullable disable
    
}
