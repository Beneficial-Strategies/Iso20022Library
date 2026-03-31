// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OtherAmountType1Choice
{
    /// <summary>
    /// Type of amount expressed as a code.
    /// </summary>
    [IsoId("_fJLzgI2NEeeNN9vGwZc5aA")]
    [DisplayName("Code")]
    public record Code : OtherAmountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of other amount.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OtherAmountType1Code Value { get; init; }
    }
}
