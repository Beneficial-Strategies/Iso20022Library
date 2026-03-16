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
[IsoId("_idcJweaOEd-q8fx_Zl_34A")]
[DisplayName("Other Parties")]
public record OtherParties12
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_idcJw-aOEd-q8fx_Zl_34A")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public ValueList<PartyIdentificationAndAccount46> Investor { get; init; } = [];

    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_idcJxeaOEd-q8fx_Zl_34A")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentificationAndAccount47? QualifiedForeignIntermediary { get; init; }

    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_idcJx-aOEd-q8fx_Zl_34A")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentificationAndAccount47? StockExchange { get; init; }

    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_idcJyeaOEd-q8fx_Zl_34A")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentificationAndAccount47? TradeRegulator { get; init; }

    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_idcJy-aOEd-q8fx_Zl_34A")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentificationAndAccount47? TripartyAgent { get; init; }

    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker, prime broker, etc).
    /// </summary>
    [IsoId("_KMORYPiiEd-FFqPP-WMLWg")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount41? Broker { get; init; }
}
