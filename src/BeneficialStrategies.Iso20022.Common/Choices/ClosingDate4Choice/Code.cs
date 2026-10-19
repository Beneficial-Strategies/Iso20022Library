// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosingDate4Choice
{
    /// <summary>
    /// Closing date is defined using a code or data source scheme.
    /// </summary>
    [IsoId("_xTU6g8pdEemQ1o-hyeYV5w")]
    [DisplayName("Code")]
    public partial record Code : ClosingDate4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required Date3Choice_ Value { get; init; }
    }
}
