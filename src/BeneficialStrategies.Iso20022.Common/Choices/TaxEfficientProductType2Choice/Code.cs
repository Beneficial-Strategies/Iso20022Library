// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxEfficientProductType2Choice
{
    /// <summary>
    /// Type of tax efficient product expressed as a code.
    /// </summary>
    [IsoId("_U2DS0ZNNEemQB_8XA98K0Q")]
    [DisplayName("Code")]
    public record Code : TaxEfficientProductType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of tax efficient product.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxEfficientProductType2Code Value { get; init; }
    }
}
