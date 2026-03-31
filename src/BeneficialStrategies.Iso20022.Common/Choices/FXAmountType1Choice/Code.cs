// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FXAmountType1Choice
{
    /// <summary>
    /// Specifies a commission or fee type.
    /// </summary>
    [IsoId("_Z-9lhQN2Ee2-vqzwMUAewg")]
    [DisplayName("Code")]
    public record Code : FXAmountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of amount for foreign exchange commissions or fees.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FXAmountType1Code Value { get; init; }
    }
}
