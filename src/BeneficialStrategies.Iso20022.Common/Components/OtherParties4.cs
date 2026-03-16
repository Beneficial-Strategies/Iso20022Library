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
[IsoId("_PXpkldp-Ed-ak6NoX_4Aeg_2044422561")]
[DisplayName("Other Parties")]
public record OtherParties4
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_PXpkltp-Ed-ak6NoX_4Aeg_1930583495")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification14Choice_? Investor { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_PXpkl9p-Ed-ak6NoX_4Aeg_1225468880")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentification10Choice_? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_PXpkmNp-Ed-ak6NoX_4Aeg_305435228")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentification10Choice_? TradeRegulator { get; init; }
}
