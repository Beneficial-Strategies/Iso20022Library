// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionRight2Choice
{
    /// <summary>
    /// Option rights expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_P_xv0ZEjEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : OptionRight2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the option rights.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionRight1Code Value { get; init; }
    }
}
