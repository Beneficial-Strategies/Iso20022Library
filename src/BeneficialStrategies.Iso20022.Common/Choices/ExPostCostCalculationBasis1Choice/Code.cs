// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExPostCostCalculationBasis1Choice
{
    /// <summary>
    /// Ex post cost calculation basis expressed as a code.
    /// </summary>
    [IsoId("_dnKIEJ9XEeqxTNfi5y7ywQ")]
    [DisplayName("Code")]
    public record Code : ExPostCostCalculationBasis1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a basis for ex post calculations.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExPostCostCalculationBasis1Code Value { get; init; }
    }
}
