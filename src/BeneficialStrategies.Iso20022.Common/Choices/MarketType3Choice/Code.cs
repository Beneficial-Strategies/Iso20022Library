// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketType3Choice
{
    /// <summary>
    /// Market type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Q08B99p-Ed-ak6NoX_4Aeg_1301322669")]
    [DisplayName("Code")]
    public record Code : MarketType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of market in which transactions take place, for example, primary.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarketType2Code Value { get; init; }
    }
}
