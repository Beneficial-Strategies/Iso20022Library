// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting quantitative details of equity instruments as part of transparency calculations.
/// </summary>
[IsoId("_pRLggWlAEeaLAKoEUNsD9g")]
[DisplayName("Transparency Data Report")]
public record TransparencyDataReport13
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_paFk5WlAEeaLAKoEUNsD9g")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_paFk52lAEeaLAKoEUNsD9g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Date to which the quantitative data fields below relate.
    /// </summary>
    [IsoId("_paFk6WlAEeaLAKoEUNsD9g")]
    [DisplayName("Reporting Date")]
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReportingDate { get; init; }

    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_paFk62lAEeaLAKoEUNsD9g")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; }

    /// <summary>
    /// Indicates whether the instrument was suspended for trading on that Trading Venue for the whole day on the given reporting day.
    /// </summary>
    [IsoId("_paFk7WlAEeaLAKoEUNsD9g")]
    [DisplayName("Suspension")]
    [IsoXmlTag("Sspnsn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Suspension { get; init; }

    /// <summary>
    /// Total number of transactions executed on the reporting day.
    /// </summary>
    [IsoId("_paFk72lAEeaLAKoEUNsD9g")]
    [DisplayName("Transactions Executed")]
    [IsoXmlTag("TxsExctd")]
    public required NumberAndVolume2 TransactionsExecuted { get; init; }

    /// <summary>
    /// Details all transactions that have been performed under a pre-trade Waiver.
    /// </summary>
    [IsoId("_paFk8WlAEeaLAKoEUNsD9g")]
    [DisplayName("Transactions Executed Excluding Pre Trade Waiver")]
    [IsoXmlTag("TxsExctdExclgPreTradWvr")]
    public required NumberAndVolume2 TransactionsExecutedExcludingPreTradeWaiver { get; init; }

    /// <summary>
    /// Details all transactions that have been performed under a post-trade large in scale waivers.
    /// </summary>
    [IsoId("_paFk82lAEeaLAKoEUNsD9g")]
    [DisplayName("Transactions Executed Excluding Post Trade Large In Scale Waiver")]
    [IsoXmlTag("TxsExctdExclgPstTradLrgInScaleWvr")]
    public required NumberAndVolume2 TransactionsExecutedExcludingPostTradeLargeInScaleWaiver { get; init; }
}
