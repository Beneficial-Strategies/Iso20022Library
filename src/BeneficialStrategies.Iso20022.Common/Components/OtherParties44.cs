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
[IsoId("_c7ObVji8Eeydid5dcNPKvg")]
[DisplayName("Other Parties")]
public record OtherParties44
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_c7ObXji8Eeydid5dcNPKvg")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public ValueList<PartyIdentificationAndAccount208> Investor { get; init; } = [];

    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_c7ObZji8Eeydid5dcNPKvg")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentificationAndAccount209? QualifiedForeignIntermediary { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_c7Obbji8Eeydid5dcNPKvg")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentificationAndAccount181? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_c7Obdji8Eeydid5dcNPKvg")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentificationAndAccount181? TradeRegulator { get; init; }

    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_c7Obfji8Eeydid5dcNPKvg")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentificationAndAccount209? TripartyAgent { get; init; }

    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker, prime broker, etc).
    /// </summary>
    [IsoId("_c7Obhji8Eeydid5dcNPKvg")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount209? Broker { get; init; }
}
