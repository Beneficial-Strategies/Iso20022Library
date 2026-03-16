// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about business parties involved in the transaction.
/// </summary>
[IsoId("_UDMVIQasEe2phaVG0lYKTw")]
[DisplayName("Other Parties")]
public record OtherParties45
{
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_UUe5dQasEe2phaVG0lYKTw")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public ValueList<PartyIdentificationAndAccount220> Investor { get; init; } = [];

    /// <summary>
    /// Party that identifies the stock exchange.
    /// </summary>
    [IsoId("_UUe5iQasEe2phaVG0lYKTw")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentificationAndAccount152? StockExchange { get; init; }

    /// <summary>
    /// Party that identifies the trade regulator.
    /// </summary>
    [IsoId("_UUe5nQasEe2phaVG0lYKTw")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentificationAndAccount152? TradeRegulator { get; init; }

    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_UUe5sQasEe2phaVG0lYKTw")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentificationAndAccount154? TripartyAgent { get; init; }

    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_UUe5xQasEe2phaVG0lYKTw")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentificationAndAccount221? QualifiedForeignIntermediary { get; init; }
}
