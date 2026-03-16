// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketType9Choice
{
    /// <summary>
    /// Market type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QlIradp-Ed-ak6NoX_4Aeg_1864785630")]
    [DisplayName("Code")]
    public record Code : MarketType9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarketType5Code Value { get; init; }
    }
}
