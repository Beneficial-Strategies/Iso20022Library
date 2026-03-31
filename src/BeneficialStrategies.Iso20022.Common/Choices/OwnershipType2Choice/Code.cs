// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnershipType2Choice
{
    /// <summary>
    /// Ownership type expressed as a code.
    /// </summary>
    [IsoId("_9esAUb-GEeWfsa741pI6WA")]
    [DisplayName("Code")]
    public record Code : OwnershipType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of account ownership.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountOwnershipType4Code Value { get; init; }
    }
}
