// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting calculation results of non equity instruments as part of transparency.
/// </summary>
[IsoId("_ZwG6IWlSEeaLAKoEUNsD9g")]
[DisplayName("Transparency Data Report")]
public record TransparencyDataReport14
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_Z5jKA2lSEeaLAKoEUNsD9g")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_Z5jKBWlSEeaLAKoEUNsD9g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Full name of the reporting entity.
    /// </summary>
    [IsoId("_Z5jKB2lSEeaLAKoEUNsD9g")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; }

    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_Z5jKCWlSEeaLAKoEUNsD9g")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Period to which the quantitative data fields relate.
    /// </summary>
    [IsoId("_Z5jKC2lSEeaLAKoEUNsD9g")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; }

    /// <summary>
    /// Flag to say if this ISIN is liquid or not post calculations.
    /// Usage:
    /// When not present, this field should be treated as not applicable.
    /// </summary>
    [IsoId("_Z5jKDWlSEeaLAKoEUNsD9g")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Liquidity { get; init; }

    /// <summary>
    /// The pre-trade Large in Scale threshold.
    /// </summary>
    [IsoId("_Z5jKD2lSEeaLAKoEUNsD9g")]
    [DisplayName("Pre Trade Large In Scale Threshold")]
    [IsoXmlTag("PreTradLrgInScaleThrshld")]
    public TonsOrCurrency2Choice_? PreTradeLargeInScaleThreshold { get; init; }

    /// <summary>
    /// The post-trade Large in Scale threshold.
    /// </summary>
    [IsoId("_Z5jKEWlSEeaLAKoEUNsD9g")]
    [DisplayName("Post Trade Large In Scale Threshold")]
    [IsoXmlTag("PstTradLrgInScaleThrshld")]
    public TonsOrCurrency2Choice_? PostTradeLargeInScaleThreshold { get; init; }

    /// <summary>
    /// The pre-trade Size Specific to an Instrument threshold.
    /// </summary>
    [IsoId("_Z5jKE2lSEeaLAKoEUNsD9g")]
    [DisplayName("Pre Trade Instrument Size Specific Threshold")]
    [IsoXmlTag("PreTradInstrmSzSpcfcThrshld")]
    public TonsOrCurrency2Choice_? PreTradeInstrumentSizeSpecificThreshold { get; init; }

    /// <summary>
    /// The post-trade Size Specific to an Instrument threshold.
    /// </summary>
    [IsoId("_Z5jKFWlSEeaLAKoEUNsD9g")]
    [DisplayName("Post Trade Instrument Size Specific Threshold")]
    [IsoXmlTag("PstTradInstrmSzSpcfcThrshld")]
    public TonsOrCurrency2Choice_? PostTradeInstrumentSizeSpecificThreshold { get; init; }

    /// <summary>
    /// Statistics for a financial instrument generated as part of transparency calculations.
    /// </summary>
    [IsoId("_Z5jKF2lSEeaLAKoEUNsD9g")]
    [DisplayName("Statistics")]
    [IsoXmlTag("Sttstcs")]
    public StatisticsTransparency2? Statistics { get; init; }
}
