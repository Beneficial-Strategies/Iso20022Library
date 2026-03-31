// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType28Choice
{
    /// <summary>
    /// Standard code to specify the type of withholding tax rate.
    /// </summary>
    [IsoId("_52pvYCeGEeOXAt_43VmZGw")]
    [DisplayName("Code")]
    public record Code : RateType28Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of withholding tax rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required WithholdingTaxRateType1Code Value { get; init; }
    }
}
