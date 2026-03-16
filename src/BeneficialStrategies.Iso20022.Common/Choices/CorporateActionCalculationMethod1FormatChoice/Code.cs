// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionCalculationMethod1FormatChoice
{
    /// <summary>
    /// Standard code to specify the calculation method for drawings.
    /// </summary>
    [IsoId("_Rl9PNNp-Ed-ak6NoX_4Aeg_-550005822")]
    [DisplayName("Code")]
    public record Code : CorporateActionCalculationMethod1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the calculation method for drawings.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionCalculationMethod1Code Value { get; init; }
    }
}
