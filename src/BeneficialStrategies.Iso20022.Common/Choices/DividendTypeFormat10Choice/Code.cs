// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DividendTypeFormat10Choice
{
    /// <summary>
    /// Standard code to specify the frequency of the corporate action event.
    /// </summary>
    [IsoId("_c5VTWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : DividendTypeFormat10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Automatic Reinvestment of Cash distributed by accumulating funds.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionFrequencyType5Code Value { get; init; }
    }
}
