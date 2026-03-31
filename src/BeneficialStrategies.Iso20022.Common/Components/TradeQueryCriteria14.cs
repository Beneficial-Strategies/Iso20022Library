// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Query Criteria14.
/// </summary>
[IsoId("_hPeV9frgEe2mU4Wi2q3MzQ")]
[DisplayName("Trade Query Criteria14")]
public record TradeQueryCriteria14
{
    /// <summary>
    /// Financial Instrument Criteria.
    /// </summary>
    [DisplayName("Financial Instrument Criteria")]
    [IsoXmlTag("FinInstrmCrit")]
    public TradeSecurityIdentificationQueryCriteria3? FinancialInstrumentCriteria { get; init; }

    /// <summary>
    /// Margin Life Cycle History.
    /// </summary>
    [DisplayName("Margin Life Cycle History")]
    [IsoXmlTag("MrgnLifeCyclHstry")]
    public IsoTrueFalseIndicator? MarginLifeCycleHistory { get; init; }

    /// <summary>
    /// Other Criteria.
    /// </summary>
    [DisplayName("Other Criteria")]
    [IsoXmlTag("OthrCrit")]
    public TradeAdditionalQueryCriteria9? OtherCriteria { get; init; }

    /// <summary>
    /// Outstanding Trade Indicator.
    /// </summary>
    [DisplayName("Outstanding Trade Indicator")]
    [IsoXmlTag("OutsdngTradInd")]
    public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; }

    /// <summary>
    /// Time Criteria.
    /// </summary>
    [DisplayName("Time Criteria")]
    [IsoXmlTag("TmCrit")]
    public TradeDateTimeQueryCriteria6? TimeCriteria { get; init; }

    /// <summary>
    /// Trade Life Cycle History.
    /// </summary>
    [DisplayName("Trade Life Cycle History")]
    [IsoXmlTag("TradLifeCyclHstry")]
    public IsoTrueFalseIndicator? TradeLifeCycleHistory { get; init; }

    /// <summary>
    /// Trade Party Criteria.
    /// </summary>
    [DisplayName("Trade Party Criteria")]
    [IsoXmlTag("TradPtyCrit")]
    public TradePartyQueryCriteria7? TradePartyCriteria { get; init; }
}
