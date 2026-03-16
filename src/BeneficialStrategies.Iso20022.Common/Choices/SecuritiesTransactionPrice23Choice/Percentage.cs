// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice23Choice
{
    /// <summary>
    /// Percentage.
    /// </summary>
    [DisplayName("Percentage")]
    public record Percentage : SecuritiesTransactionPrice23Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Pctg")]
        public required IsoPercentageRate Value { get; init; }
    }
}
