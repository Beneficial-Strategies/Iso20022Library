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
[IsoId("_ZC9Igfp2Ee-b4ekxD4W-5g")]
[DisplayName("Transparency Data Report22")]
public record TransparencyDataReport22
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    [IsoId("_ZD6x1fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_ZD6x1_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Specifies the classification of the equity instrument.
    /// </summary>
    [IsoId("_ZD6x2fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public EquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; }

    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    [IsoId("_ZD6x2_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    public IsoMax350Text? FullName { get; init; }

    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_ZD6x3fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Period to which the quantitative data fields relate.
    /// </summary>
    [IsoId("_ZD6x3_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; }

    /// <summary>
    /// Period of application of the results.
    /// </summary>
    [IsoId("_lbPT0Pp2Ee-b4ekxD4W-5g")]
    [DisplayName("Application Period")]
    [IsoXmlTag("ApplPrd")]
    public Period4Choice_? ApplicationPeriod { get; init; }

    /// <summary>
    /// Flag to say if this ISIN is liquid or not post calculations.
    /// </summary>
    [IsoId("_ZD6x4fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    public IsoTrueFalseIndicator? Liquidity { get; init; }

    /// <summary>
    /// Methodology that has been used to calculate the result.
    /// </summary>
    [IsoId("_ZD6x4_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Methodology")]
    [IsoXmlTag("Mthdlgy")]
    public TransparencyMethodology2Code? Methodology { get; init; }

    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    [IsoId("_ZD6x5fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Statistics")]
    [IsoXmlTag("Sttstcs")]
    public StatisticsTransparency3? Statistics { get; init; }

    /// <summary>
    /// Specific market details related to the most relevant market in terms of liquidity.
    /// </summary>
    [IsoId("_ZD6x5_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Relevant Market")]
    [IsoXmlTag("RlvntMkt")]
    public MarketDetail2? RelevantMarket { get; init; }
}
