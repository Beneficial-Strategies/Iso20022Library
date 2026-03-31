// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrGroup3Choice
{
    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    public record Party : PartyOrGroup3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Pty")]
        public required PartyAndCertificate6 Value { get; init; }
    }
}
