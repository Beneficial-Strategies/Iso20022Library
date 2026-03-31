// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DividendTypeFormat5Choice
{
    /// <summary>
    /// Standard code to specify the frequency of the corporate action event.
    /// </summary>
    [IsoId("_debt0yXfEeO4bIO_HtGo9Q")]
    [DisplayName("Code")]
    public record Code : DividendTypeFormat5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Automatic Reinvestment of Cash distributed by accumulating funds.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionFrequencyType3Code Value { get; init; }
    }
}
