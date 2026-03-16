// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyRole6Choice
{
    /// <summary>
    /// Role expressed as a code.
    /// </summary>
    [IsoId("_Ny0LtI6OEemzmeK8_tPygg")]
    [DisplayName("Code")]
    public record Code : PartyRole6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the party in the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PartyRole2Code Value { get; init; }
    }
}
