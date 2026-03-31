// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeFrame9Choice
{
    /// <summary>
    /// Time frame expressed as a code.
    /// </summary>
    [IsoId("_Uz2OgcztEeq1WLK5fVzKiQ")]
    [DisplayName("Code")]
    public record Code : TimeFrame9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a time frame.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TimeFrame2Code Value { get; init; }
    }
}
