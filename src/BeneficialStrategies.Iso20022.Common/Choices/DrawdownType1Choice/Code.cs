// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DrawdownType1Choice
{
    /// <summary>
    /// Type of drawdown expressed as a code.
    /// </summary>
    [IsoId("_SdXqYFNdEeijdq8ilaxyOA")]
    [DisplayName("Code")]
    public record Code : DrawdownType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of drawdown.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DrawdownType1Code Value { get; init; }
    }
}
