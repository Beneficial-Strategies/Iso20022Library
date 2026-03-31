// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError9Choice
{
    /// <summary>
    /// Report.
    /// </summary>
    [DisplayName("Report")]
    public record Report : StandingOrderOrError9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rpt")]
        public required StandingOrderReport3 Value { get; init; }
    }
}
