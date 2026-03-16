// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateCode32Choice
{
    /// <summary>
    /// Date expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5mw3vZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : DateCode32Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType5Code Value { get; init; }
    }
}
