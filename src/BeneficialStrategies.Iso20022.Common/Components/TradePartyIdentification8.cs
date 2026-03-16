// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the trade party.
/// </summary>
[IsoId("_CKT6BQN1Ee2-vqzwMUAewg")]
[DisplayName("Trade Party Identification")]
public record TradePartyIdentification8
{
    /// <summary>
    /// Party that submits the foreign exchange trade to the matching system or to the settlement system or to the counterparty.
    /// </summary>
    [IsoId("_CQNIWwN1Ee2-vqzwMUAewg")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    public required PartyIdentification242Choice_ SubmittingParty { get; init; }

    /// <summary>
    /// Party that originated the foreign exchange trade. This party may be the same as the submitting party.
    /// </summary>
    [IsoId("_CQNIXQN1Ee2-vqzwMUAewg")]
    [DisplayName("Trade Party")]
    [IsoXmlTag("TradPty")]
    public PartyIdentification242Choice_? TradeParty { get; init; }

    /// <summary>
    /// Identifies the fund that is one of the parties in the foreign exchange trade.
    /// </summary>
    [IsoId("_CQNIXwN1Ee2-vqzwMUAewg")]
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    public FundIdentification5? FundIdentification { get; init; }
}
