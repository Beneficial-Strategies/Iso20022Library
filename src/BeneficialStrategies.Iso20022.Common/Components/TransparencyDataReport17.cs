// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting calculation results of equity instruments as part of transparency.
/// </summary>
[IsoId("_vqBVsSe2Eei12pGEsJIAeQ")]
[DisplayName("Transparency Data Report")]
public record TransparencyDataReport17
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_v0EplSe2Eei12pGEsJIAeQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_v0Eplye2Eei12pGEsJIAeQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Specifies the classification of the equity instrument.
    /// </summary>
    [IsoId("_wJWWACe2Eei12pGEsJIAeQ")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public EquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; }

    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    [IsoId("_v0EpmSe2Eei12pGEsJIAeQ")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; }

    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_v0Epmye2Eei12pGEsJIAeQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Period to which the quantitative data fields relate.
    /// </summary>
    [IsoId("_v0EpnSe2Eei12pGEsJIAeQ")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; }

    /// <summary>
    /// Flag to say if this ISIN is liquid or not post calculations.
    /// Usage:
    /// When not present, this field should be treated as not applicable.
    /// </summary>
    [IsoId("_v0Epnye2Eei12pGEsJIAeQ")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Liquidity { get; init; }

    /// <summary>
    /// Methodology that has been used to calculate the result.
    /// </summary>
    [IsoId("_v0EpoSe2Eei12pGEsJIAeQ")]
    [DisplayName("Methodology")]
    [IsoXmlTag("Mthdlgy")]
    public TransparencyMethodology2Code? Methodology { get; init; }

    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    [IsoId("_v0Epoye2Eei12pGEsJIAeQ")]
    [DisplayName("Statistics")]
    [IsoXmlTag("Sttstcs")]
    public StatisticsTransparency3? Statistics { get; init; }

    /// <summary>
    /// Specific market details related to the most relevant market in terms of liquidity.
    /// </summary>
    [IsoId("_v0EppSe2Eei12pGEsJIAeQ")]
    [DisplayName("Relevant Market")]
    [IsoXmlTag("RlvntMkt")]
    public MarketDetail2? RelevantMarket { get; init; }
}
