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
[IsoId("_blbC0TqmEeWyoP0PbocV1Q")]
[DisplayName("Other Parties")]
public record OtherParties28
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_cF22RTqmEeWyoP0PbocV1Q")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification99? Investor { get; init; }

    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_cF22TTqmEeWyoP0PbocV1Q")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentification100? QualifiedForeignIntermediary { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_cF22VTqmEeWyoP0PbocV1Q")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentification100? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_cF22XTqmEeWyoP0PbocV1Q")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentification100? TradeRegulator { get; init; }

    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_cF22ZTqmEeWyoP0PbocV1Q")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentification100? TripartyAgent { get; init; }
}
