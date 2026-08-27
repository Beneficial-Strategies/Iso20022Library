// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument related data.
/// </summary>
[IsoId("_2HTIMGFSEfC91ZUW7iS7ww")]
[DisplayName("Instrument Data1")]
public record InstrumentData1
{
    /// <summary>
    /// Data related to the identification of an instrument.
    /// </summary>
    [IsoId("_CFyTcGFTEfC91ZUW7iS7ww")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public required FinancialInstrumentAttributes140 Instrument { get; init; }

    /// <summary>
    /// Description of the status of the financial instrument.
    /// </summary>
    [IsoId("_onnssKUOEfCmoeslmyBN5Q")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required SecurityStatus3Code Status { get; init; }

    /// <summary>
    /// Date and time from which the instrument status is valid.
    /// </summary>
    [IsoId("_jZh3MKUOEfCmoeslmyBN5Q")]
    [DisplayName("Status Start Date Time")]
    [IsoXmlTag("StsStartDtTm")]
    public required IsoISODateTime StatusStartDateTime { get; init; }

    /// <summary>
    /// Identification of the trading venue on which the instrument status is valid.
    /// </summary>
    [IsoId("_FUcn0GFTEfC91ZUW7iS7ww")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public required IsoMICIdentifier TradingVenue { get; init; }

    /// <summary>
    /// Information about the trading system where the instrument is traded.
    /// </summary>
    [IsoId("_Hpl6QGFTEfC91ZUW7iS7ww")]
    [DisplayName("Trading System")]
    [IsoXmlTag("TradgSys")]
    public TradingSystemData3? TradingSystem { get; init; }

    /// <summary>
    /// Identification of the trading venue being the most relevant market.
    /// Usage: Only applicable for the output data of the Equity Consolidated Tape Provider (CTP).
    /// </summary>
    [IsoId("_MNjNoGFTEfC91ZUW7iS7ww")]
    [DisplayName("Most Relevant Market")]
    [IsoXmlTag("MostRlvntMkt")]
    public IsoTrueFalseIndicator? MostRelevantMarket { get; init; }

    /// <summary>
    /// Date and time from which the instrument status or the data are disseminated by the Consolidated Tape Provider (CTP).
    ///
    /// Usage: Only applicable for output data.
    /// </summary>
    [IsoId("_QxbogGFTEfC91ZUW7iS7ww")]
    [DisplayName("Dissemination Date Time")]
    [IsoXmlTag("DssmntnDtTm")]
    public IsoISODateTime? DisseminationDateTime { get; init; }
}
