// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status28Choice
{
    /// <summary>
    /// Status expressed as a code.
    /// </summary>
    [IsoId("_tsd0gZU8EeaYkf5FCqYMeA")]
    [DisplayName("Code")]
    public record Code : Status28Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a trade in a central matching and settlement system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradeStatus7Code Value { get; init; }
    }
}
