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
[IsoId("_hMBrsSqGEeyR9JrVGfaMKw")]
[DisplayName("Other Parties")]
public record OtherParties43
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_hk6FxyqGEeyR9JrVGfaMKw")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public ValueList<PartyIdentificationAndAccount197> Investor { get; init; } = [];

    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_hk6FzyqGEeyR9JrVGfaMKw")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentificationAndAccount198? QualifiedForeignIntermediary { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_hk6F1yqGEeyR9JrVGfaMKw")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentificationAndAccount165? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_hk6F3yqGEeyR9JrVGfaMKw")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentificationAndAccount165? TradeRegulator { get; init; }

    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_hk6F5yqGEeyR9JrVGfaMKw")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentificationAndAccount198? TripartyAgent { get; init; }

    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker, prime broker, etc).
    /// </summary>
    [IsoId("_hk6F7yqGEeyR9JrVGfaMKw")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount198? Broker { get; init; }
}
