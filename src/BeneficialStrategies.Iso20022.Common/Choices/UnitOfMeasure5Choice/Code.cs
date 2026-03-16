// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure5Choice
{
    /// <summary>
    /// Specifies unit of quantity of a commodity or financial instrument.
    /// </summary>
    [IsoId("_wR_yAPp2EeaQh_7a05rSJQ")]
    [DisplayName("Code")]
    public record Code : UnitOfMeasure5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Unit of measure of the item purchased.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required UnitOfMeasure8Code Value { get; init; }
    }
}
