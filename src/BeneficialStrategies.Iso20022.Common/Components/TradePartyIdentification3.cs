// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_PdKWsdp-Ed-ak6NoX_4Aeg_-1580495666")]
[DisplayName("Trade Party Identification")]
public record TradePartyIdentification3
{
    /// <summary>
    /// Identifies the fund which is one of the parties in a treasury trade.
    /// </summary>
    [IsoId("_PdKWstp-Ed-ak6NoX_4Aeg_2125581687")]
    [DisplayName("Fund Information")]
    [IsoXmlTag("FndInf")]
    public FundIdentification2? FundInformation { get; init; }

    /// <summary>
    /// Specifies the party which submits a treasury trade to a matching system or to a settlement system or to a counterparty.
    /// </summary>
    [IsoId("_PdKWs9p-Ed-ak6NoX_4Aeg_-1580495262")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    public required PartyIdentification8Choice_ SubmittingParty { get; init; }

    /// <summary>
    /// Specifies the party which originated a treasury trade. This party may be the same as the submitting party.
    /// </summary>
    [IsoId("_PdKWtNp-Ed-ak6NoX_4Aeg_-1580495304")]
    [DisplayName("Trade Party")]
    [IsoXmlTag("TradPty")]
    public required PartyIdentification8Choice_ TradeParty { get; init; }
}
