// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification235Choice
{
    /// <summary>
    /// The party is a legal person.
    /// </summary>
    [IsoId("_2CSAgO9KEemVGdgB8P8uQQ")]
    [DisplayName("Legal")]
    public record Legal : PartyIdentification235Choice_ { }
}
