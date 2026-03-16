// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError9Choice
{
    /// <summary>
    /// Operational Error.
    /// </summary>
    [DisplayName("Operational Error")]
    public record OperationalError : StandingOrderOrError9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("OprlErr")]
        public required ErrorHandling5 Value { get; init; }
    }
}
