// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DetailedTransactionStatistics7Choice
{
    /// <summary>
    /// Detailed Statistics.
    /// </summary>
    [DisplayName("Detailed Statistics")]
    public record DetailedStatistics : DetailedTransactionStatistics7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DtldSttstcs")]
        public required DetailedTransactionStatistics30 Value { get; init; }
    }
}
