// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketType12Choice
{
    /// <summary>
    /// Market type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Ac1ic9okEeC60axPepSq7g_-1423568581")]
    [DisplayName("Code")]
    public record Code : MarketType12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of market in which transactions take place, for example, primary.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarketType2Code Value { get; init; }
    }
}
