// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError10Choice
{
    /// <summary>
    /// Cancellations.
    /// </summary>
    [DisplayName("Cancellations")]
    public record Cancellations : IntraBalanceOrOperationalError10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cxls")]
        public required IntraBalanceCancellation7 Value { get; init; }
    }
}
