// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeBasis2Choice
{
    /// <summary>
    /// Fee (charge/commission) basis expressed as a code.
    /// </summary>
    [IsoId("_9tIUYjh5EeaH-93K5JKmzw")]
    [DisplayName("Code")]
    public record Code : ChargeBasis2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tax or charge basis.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxationBasis5Code Value { get; init; }
    }
}
