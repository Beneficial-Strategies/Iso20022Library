// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxEfficientProductType1Choice
{
    /// <summary>
    /// Type of tax efficient product expressed as a code.
    /// </summary>
    [IsoId("_He0uEE4LEeiQHa-q1Uephw")]
    [DisplayName("Code")]
    public record Code : TaxEfficientProductType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of tax efficient product.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxEfficientProductType1Code Value { get; init; }
    }
}
