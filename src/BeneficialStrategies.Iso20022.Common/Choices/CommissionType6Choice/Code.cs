// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CommissionType6Choice
{
    /// <summary>
    /// Commission type is identified using a code.
    /// </summary>
    [IsoId("_Sj9R85BhEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : CommissionType6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of service for which the commission is asked or paid.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommissionType9Code Value { get; init; }
    }
}
