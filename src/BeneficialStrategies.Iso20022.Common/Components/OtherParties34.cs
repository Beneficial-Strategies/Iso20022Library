// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of other parties.
/// </summary>
[IsoId("__eyZsdLCEeiN28wlpBQScw")]
[DisplayName("Other Parties")]
public record OtherParties34
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("__wyvtdLCEeiN28wlpBQScw")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification149? Investor { get; init; }

    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("__wyvvdLCEeiN28wlpBQScw")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentification136? QualifiedForeignIntermediary { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("__wyvxdLCEeiN28wlpBQScw")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentification136? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("__wyvzdLCEeiN28wlpBQScw")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentification136? TradeRegulator { get; init; }

    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("__wyv1dLCEeiN28wlpBQScw")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentification136? TripartyAgent { get; init; }
}
