// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateValueType6FormatChoice
{
    /// <summary>
    /// Standard code to specify the value of a rate.
    /// </summary>
    [IsoId("_Rn5I6Np-Ed-ak6NoX_4Aeg_-1089918465")]
    [DisplayName("Code")]
    public record Code : RateValueType6FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateValueType6Code Value { get; init; }
    }
}
