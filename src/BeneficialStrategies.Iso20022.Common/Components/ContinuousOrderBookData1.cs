// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the continuous order books for the pre-trade output report.
/// </summary>
[IsoId("_ei7XgGIZEfCeoPFCHQnhvA")]
[DisplayName("Continuous Order Book Data1")]
public record ContinuousOrderBookData1
{
    /// <summary>
    /// The CTP shall publish the most recent amongst the dates and times of the best bids and offers entered into the order book that participate in the BBO as reported by the data contributors.
    /// </summary>
    [IsoId("_9iyh8GIZEfCeoPFCHQnhvA")]
    [DisplayName("Entry Date Time")]
    [IsoXmlTag("NtryDtTm")]
    public required IsoISODateTime EntryDateTime { get; init; }

    /// <summary>
    /// Date and time of the calculation of the Best Bid and Offer (BBO).
    /// </summary>
    [IsoId("_LbnS8GIaEfCeoPFCHQnhvA")]
    [DisplayName("Calculation Date Time")]
    [IsoXmlTag("ClctnDtTm")]
    public required IsoISODateTime CalculationDateTime { get; init; }

    /// <summary>
    /// Data related to the bid for continuous order books.
    /// </summary>
    [IsoId("_khfLMGIaEfCeoPFCHQnhvA")]
    [DisplayName("Bid")]
    [IsoXmlTag("Bid")]
    public required BidData1 Bid { get; init; }

    /// <summary>
    /// Data related to the offer for continuous order books.
    /// </summary>
    [IsoId("_ASvPIGIcEfCeoPFCHQnhvA")]
    [DisplayName("Offer")]
    [IsoXmlTag("Offer")]
    public required OfferData1 Offer { get; init; }

    /// <summary>
    /// Major currency unit in which the best bid and offer prices are expressed.
    /// </summary>
    [IsoId("_GByGUGlTEfCI49VeRStxJw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }
}
