// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Disclosure2Choice
{
    /// <summary>
    /// Shareholding information is not disclosed.
    /// </summary>
    [IsoId("_MM9hYfNyEeqRfth943bvEA")]
    [DisplayName("No Disclosure")]
    public record NoDisclosure : Disclosure2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NoDsclsr")]
        public required NoReasonCode Value { get; init; }
    }
}
