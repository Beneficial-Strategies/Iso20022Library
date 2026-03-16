// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification260Choice
{
    /// <summary>
    /// Natural Person.
    /// </summary>
    [DisplayName("Natural Person")]
    public record NaturalPerson : PartyIdentification260Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NtrlPrsn")]
        public required NaturalPersonIdentification5 Value { get; init; }
    }
}
