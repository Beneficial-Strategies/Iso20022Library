// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CommissionType3Choice
{
    /// <summary>
    /// Type of commission expressed as a code.
    /// </summary>
    [IsoId("_cz6_MBuBEeOqSdXzJ0oydA")]
    [DisplayName("Code")]
    public record Code : CommissionType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investment fund commission.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommissionType7Code Value { get; init; }
    }
}
