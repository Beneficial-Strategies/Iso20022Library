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
[IsoId("_mtxTt-mvEemUgrefIx730g")]
[DisplayName("Other Parties")]
public record OtherParties39
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_nbcSBemvEemUgrefIx730g")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification149? Investor { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_nbcSDemvEemUgrefIx730g")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentification136? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_nbcSFemvEemUgrefIx730g")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentification136? TradeRegulator { get; init; }
}
