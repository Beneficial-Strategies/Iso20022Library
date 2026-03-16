// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord2Choice
{
    /// <summary>
    /// Contact Details.
    /// </summary>
    [DisplayName("Contact Details")]
    public record ContactDetails : UpdateLogPartyRecord2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CtctDtls")]
        public required UpdateLogContact2 Value { get; init; }
    }
}
