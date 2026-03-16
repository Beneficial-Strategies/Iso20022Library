// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice
{
    /// <summary>
    /// Standing Order.
    /// </summary>
    [DisplayName("Standing Order")]
    public record StandingOrder : StandingOrderOrAll4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StgOrdr")]
        public required StandingOrderIdentification8 Value { get; init; }
    }
}
