// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus4Choice
{
    /// <summary>
    /// Status of the transfer is received, accepted, sent to next party, matched, already executed, or settled.
    /// </summary>
    [IsoId("_fmnCcZM5EemKz5EOjv82iQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public record Status : TransferStatus4Choice_
    {
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required TransferStatus6Code Value { get; init; }

        /// <summary>
        /// Reason for the status.
        /// </summary>
        [IsoId("_avAfhVNUEeijdq8ilaxyOA")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Reason { get; init; }
    }
}
