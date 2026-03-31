// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfPrice47Choice
{
    /// <summary>
    /// Type of price expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Pt3Ok5BhEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : TypeOfPrice47Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of price and information about the price.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfPrice3Code Value { get; init; }
    }
}
