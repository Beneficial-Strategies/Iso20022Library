// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties34Choice
{
    /// <summary>
    /// Identification of the indirect participant of the reporting counterparty involved in the transaction.
    /// </summary>
    [IsoId("_viBlU8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Indirect Participant")]
    public record IndirectParticipant : SettlementParties34Choice_ { }
}
