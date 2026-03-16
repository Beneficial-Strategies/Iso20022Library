// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlingCapacity9Choice
{
    /// <summary>
    /// Settlement capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_hd6mM5EZEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : SettlingCapacity9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the party in the settlement of the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlingCapacity1Code Value { get; init; }
    }
}
