// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification251Choice
{
    /// <summary>
    /// Name And Address.
    /// </summary>
    [DisplayName("Name And Address")]
    public record NameAndAddress : PartyIdentification251Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NmAndAdr")]
        public required NameAndAddress8 Value { get; init; }
    }
}
