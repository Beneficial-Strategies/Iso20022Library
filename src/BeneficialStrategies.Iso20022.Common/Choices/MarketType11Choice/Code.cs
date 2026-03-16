// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketType11Choice
{
    /// <summary>
    /// Market type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AcsYgNokEeC60axPepSq7g_568526446")]
    [DisplayName("Code")]
    public record Code : MarketType11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarketType6Code Value { get; init; }
    }
}
