// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferUnmatchedStatus3Choice
{
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    [IsoId("_eLXpxSY4EeW_ZNn8gbfY7Q")]
    [DisplayName("Reason")]
    public record Reason : TransferUnmatchedStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transfer or settlement instruction unmatched status.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required TransferUnmatchedReason2Code Value { get; init; }
    }
}
