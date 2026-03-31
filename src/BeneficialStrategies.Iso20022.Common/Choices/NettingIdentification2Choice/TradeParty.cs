// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NettingIdentification2Choice
{
    /// <summary>
    /// Describes the individual trading party.
    /// </summary>
    [IsoId("_CKT6AQN1Ee2-vqzwMUAewg")]
    [DisplayName("Trade Party")]
    public record TradeParty : NettingIdentification2Choice_ { }
}
