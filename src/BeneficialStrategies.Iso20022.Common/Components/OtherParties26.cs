// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other parties information.
/// </summary>
[IsoId("_JfYFQR5dEeWE3PufGMdJ3w")]
[DisplayName("Other Parties")]
public record OtherParties26
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_J-xWZR5dEeWE3PufGMdJ3w")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification99? Investor { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_J-xWbR5dEeWE3PufGMdJ3w")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentification100? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_J-xWdR5dEeWE3PufGMdJ3w")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentification100? TradeRegulator { get; init; }
}
