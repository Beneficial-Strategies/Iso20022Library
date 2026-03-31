// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Party Identification9.
/// </summary>
[IsoId("_ul5uAXfaEe2I4Iip2NEM0A")]
[DisplayName("Trade Party Identification9")]
public record TradePartyIdentification9
{
    /// <summary>
    /// Buyer Or Seller Indicator.
    /// </summary>
    [DisplayName("Buyer Or Seller Indicator")]
    [IsoXmlTag("BuyrOrSellrInd")]
    public required OptionParty1Code BuyerOrSellerIndicator { get; init; }

    /// <summary>
    /// Fund Information.
    /// </summary>
    [DisplayName("Fund Information")]
    [IsoXmlTag("FndInf")]
    public FundIdentification6? FundInformation { get; init; }

    /// <summary>
    /// Initiator Indicator.
    /// </summary>
    [DisplayName("Initiator Indicator")]
    [IsoXmlTag("InitrInd")]
    public required OptionParty3Code InitiatorIndicator { get; init; }

    /// <summary>
    /// Submitting Party.
    /// </summary>
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    public required PartyIdentificationAndAccount119 SubmittingParty { get; init; }

    /// <summary>
    /// Trade Party Identification.
    /// </summary>
    [DisplayName("Trade Party Identification")]
    [IsoXmlTag("TradPtyId")]
    public required PartyIdentification78 TradePartyIdentification { get; init; }
}
