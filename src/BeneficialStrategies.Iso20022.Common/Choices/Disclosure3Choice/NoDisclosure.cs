// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Disclosure3Choice
{
    /// <summary>
    /// No Disclosure.
    /// </summary>
    [DisplayName("No Disclosure")]
    public record NoDisclosure : Disclosure3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NoDsclsr")]
        public required NoReasonCode Value { get; init; }
    }
}
