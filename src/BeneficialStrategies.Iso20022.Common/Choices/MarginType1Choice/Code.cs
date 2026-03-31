// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginType1Choice
{
    /// <summary>
    /// Provides the margin type using a code.
    /// </summary>
    [IsoId("_-axnkaMOEeCojJW5vEuTEQ_8773811")]
    [DisplayName("Code")]
    public record Code : MarginType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarginType1Code Value { get; init; }
    }
}
