// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status31Choice
{
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    [IsoId("_ym2jwZM6EemKz5EOjv82iQ")]
    [DisplayName("Status")]
    public record Status : Status31Choice_
    {
        /// <summary>
        /// Status of the transfer cancellation is accepted or sent to next party.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required CancellationStatus5Code Value { get; init; }

        /// <summary>
        /// Reason for the status.
        /// </summary>
        [IsoId("_6UCR5ZM6EemKz5EOjv82iQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Reason { get; init; }
    }
}
