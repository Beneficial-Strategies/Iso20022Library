// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType6Choice
{
    /// <summary>
    /// Standard code to specify the type of rate.
    /// </summary>
    [IsoId("_Q2kZo9p-Ed-ak6NoX_4Aeg_-382627273")]
    [DisplayName("Code")]
    public record Code : RateType6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateType7Code Value { get; init; }
    }
}
