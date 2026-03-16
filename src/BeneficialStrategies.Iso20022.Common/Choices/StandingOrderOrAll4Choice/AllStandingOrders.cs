// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice
{
    /// <summary>
    /// All Standing Orders.
    /// </summary>
    [DisplayName("All Standing Orders")]
    public record AllStandingOrders : StandingOrderOrAll4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AllStgOrdrs")]
        public required StandingOrderIdentification9 Value { get; init; }
    }
}
