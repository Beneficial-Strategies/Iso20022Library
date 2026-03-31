// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus2Choice
{
    /// <summary>
    /// Status of the transfer is received, accepted, sent to next party, matched, already executed, or settled.
    /// </summary>
    [IsoId("_aQ-GMSY3EeW_ZNn8gbfY7Q")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public record Status : TransferStatus2Choice_
    {
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoXmlTag("Sts")]
        public required TransferStatus4Code Value { get; init; }

        /// <summary>
        /// Reason for the status.
        /// </summary>
        [IsoId("_Ibc8hSY_EeW_ZNn8gbfY7Q")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Reason { get; init; }
    }
}
