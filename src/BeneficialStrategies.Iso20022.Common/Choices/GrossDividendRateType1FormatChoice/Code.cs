// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of gross dividend rate.
    /// </summary>
    [IsoId("_Rms2ENp-Ed-ak6NoX_4Aeg_-8475313")]
    [DisplayName("Code")]
    public record Code : GrossDividendRateType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of gross dividend rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GrossDividendRateType1Code Value { get; init; }
    }
}
