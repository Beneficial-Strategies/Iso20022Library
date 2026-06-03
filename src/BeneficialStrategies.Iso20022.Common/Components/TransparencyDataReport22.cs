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
    [IsoId("_ZD6x1fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    [IsoId("_ZD6x1_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoISINOct2015Identifier Identification { get; init; }

    [IsoId("_ZD6x2fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public EquityInstrumentReportingClassification1Code? FinancialInstrumentClassification { get; init; }

    [IsoId("_ZD6x2_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    public IsoMax350Text? FullName { get; init; }

    [IsoId("_ZD6x3fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public IsoMICIdentifier? TradingVenue { get; init; }

    [IsoId("_ZD6x3_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice? ReportingPeriod { get; init; }

    [IsoId("_lbPT0Pp2Ee-b4ekxD4W-5g")]
    [DisplayName("Application Period")]
    [IsoXmlTag("ApplPrd")]
    public Period4Choice? ApplicationPeriod { get; init; }

    [IsoId("_ZD6x4fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    public IsoTrueFalseIndicator? Liquidity { get; init; }

    [IsoId("_ZD6x4_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Methodology")]
    [IsoXmlTag("Mthdlgy")]
    public TransparencyMethodology2Code? Methodology { get; init; }

    [IsoId("_ZD6x5fp2Ee-b4ekxD4W-5g")]
    [DisplayName("Statistics")]
    [IsoXmlTag("Sttstcs")]
    public StatisticsTransparency3? Statistics { get; init; }

    [IsoId("_ZD6x5_p2Ee-b4ekxD4W-5g")]
    [DisplayName("Relevant Market")]
    [IsoXmlTag("RlvntMkt")]
    public MarketDetail2? RelevantMarket { get; init; }
}
