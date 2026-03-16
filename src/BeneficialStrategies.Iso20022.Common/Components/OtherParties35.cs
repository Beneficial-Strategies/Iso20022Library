// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other parties&apos; information.
/// </summary>
[IsoId("_6svim_fVEeiNZp_PtLohLw")]
[DisplayName("Other Parties")]
public record OtherParties35
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_6svio_fVEeiNZp_PtLohLw")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public ValueList<PartyIdentificationAndAccount179> Investor { get; init; } = [];

    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_6sviq_fVEeiNZp_PtLohLw")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentificationAndAccount180? QualifiedForeignIntermediary { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_6svis_fVEeiNZp_PtLohLw")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentificationAndAccount181? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_6sviu_fVEeiNZp_PtLohLw")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentificationAndAccount181? TradeRegulator { get; init; }

    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_6sviw_fVEeiNZp_PtLohLw")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentificationAndAccount180? TripartyAgent { get; init; }

    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker, prime broker, etc).
    /// </summary>
    [IsoId("_6sviy_fVEeiNZp_PtLohLw")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount180? Broker { get; init; }
}
