// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Date3Choice
{
    /// <summary>
    /// Date is defined using a code.
    /// </summary>
    [IsoId("_U01FIZEhEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : Date3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is open.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType2Code Value { get; init; }
    }
}
