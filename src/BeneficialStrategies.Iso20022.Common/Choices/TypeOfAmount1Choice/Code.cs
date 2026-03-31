// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfAmount1Choice
{
    /// <summary>
    /// Type of amount expressed as a code.
    /// </summary>
    [IsoId("_g7_wgF24EeiFXdiLi_Nf4A")]
    [DisplayName("Code")]
    public record Code : TypeOfAmount1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of amount.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxWrapperAmountType1Code Value { get; init; }
    }
}
