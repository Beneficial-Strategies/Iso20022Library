// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrBusinessError4Choice
{
    /// <summary>
    /// System Party.
    /// </summary>
    [DisplayName("System Party")]
    public record SystemParty : PartyOrBusinessError4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("SysPty")]
        public required SystemParty6 Value { get; init; }
    }
}
