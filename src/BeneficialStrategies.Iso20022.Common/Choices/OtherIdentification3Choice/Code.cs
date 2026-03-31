// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OtherIdentification3Choice
{
    /// <summary>
    /// Type of identification expressed as a code.
    /// </summary>
    [IsoId("_1U8xUSCOEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public record Code : OtherIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alternative identification of a party, for example, national registration identification number, passport number, tax identification number.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PartyIdentificationType7Code Value { get; init; }
    }
}
