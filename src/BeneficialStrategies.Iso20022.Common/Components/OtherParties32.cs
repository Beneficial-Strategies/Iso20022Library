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
[IsoId("_IYTBIZBfEeakHoV5BVecAQ")]
[DisplayName("Other Parties")]
public record OtherParties32
{
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_IpGdRZBfEeakHoV5BVecAQ")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public ValueList<PartyIdentificationAndAccount150> Investor { get; init; } = [];

    /// <summary>
    /// Party that identifies the stock exchange.
    /// </summary>
    [IsoId("_IpGdWZBfEeakHoV5BVecAQ")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentificationAndAccount152? StockExchange { get; init; }

    /// <summary>
    /// Party that identifies the trade regulator.
    /// </summary>
    [IsoId("_IpGdbZBfEeakHoV5BVecAQ")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentificationAndAccount152? TradeRegulator { get; init; }

    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_IpGdgZBfEeakHoV5BVecAQ")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentificationAndAccount154? TripartyAgent { get; init; }

    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_IpGdlZBfEeakHoV5BVecAQ")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentificationAndAccount151? QualifiedForeignIntermediary { get; init; }
}
