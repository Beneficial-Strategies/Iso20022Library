// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction.
/// </summary>
[IsoId("_zCSKIK0mEemlgIolf65eZg")]
[DisplayName("Loan Data")]
public record LoanData85
{
    /// <summary>
    /// Unique reference assigned to the transaction to identify the trade.
    /// </summary>
    [IsoId("_ErQzA60nEemlgIolf65eZg")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    [IsoId("_ErQzBK0nEemlgIolf65eZg")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EventDate { get; init; }

    /// <summary>
    /// Market value of the securities or commodities on loan or borrowed.
    /// </summary>
    [IsoId("_ErQzBa0nEemlgIolf65eZg")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public required ActiveOrHistoricCurrencyAndAmount MarketValue { get; init; }
}
