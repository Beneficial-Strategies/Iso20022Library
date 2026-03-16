// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus8Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RQy3gtp-Ed-ak6NoX_4Aeg_88630331")]
    [DisplayName("Reason")]
    public record Reason : RejectedStatus8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transfer or settlement instruction rejected status.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required TransferRejectedStatusReason2Code Value { get; init; }
    }
}
