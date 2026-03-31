// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status31Choice
{
    /// <summary>
    /// Status of the transfer cancellation is pending.
    /// </summary>
    [IsoId("_ym2jx5M6EemKz5EOjv82iQ")]
    [DisplayName("Pending")]
    public record Pending : Status31Choice_
    {
        /// <summary>
        /// Reason for the cancellation pending status.
        /// </summary>
        [IsoId("_RQf8mNp-Ed-ak6NoX_4Aeg_1012324216")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Reason { get; init; }
    }
}
