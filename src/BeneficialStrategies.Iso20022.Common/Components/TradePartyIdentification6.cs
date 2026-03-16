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
[IsoId("_rbRD8SjaEeK1Sbo8NpBROA")]
[DisplayName("Trade Party Identification")]
public record TradePartyIdentification6
{
    /// <summary>
    /// Party that submits the foreign exchange trade to the matching system or to the settlement system or to the counterparty.
    /// </summary>
    [IsoId("_rou4OSjaEeK1Sbo8NpBROA")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    public required PartyIdentification73Choice_ SubmittingParty { get; init; }

    /// <summary>
    /// Party that originated the foreign exchange trade. This party may be the same as the submitting party.
    /// </summary>
    [IsoId("_rou4PSjaEeK1Sbo8NpBROA")]
    [DisplayName("Trade Party")]
    [IsoXmlTag("TradPty")]
    public PartyIdentification73Choice_? TradeParty { get; init; }

    /// <summary>
    /// Identifies the fund that is one of the parties in the foreign exchange trade.
    /// </summary>
    [IsoId("_rou4QSjaEeK1Sbo8NpBROA")]
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    public FundIdentification4? FundIdentification { get; init; }
}
