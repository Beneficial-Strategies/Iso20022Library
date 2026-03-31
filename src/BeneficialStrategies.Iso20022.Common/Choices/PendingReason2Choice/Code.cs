// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason2Choice
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_UYeaJtp-Ed-ak6NoX_4Aeg_-2106070752")]
    [DisplayName("Code")]
    public record Code : PendingReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why a cancellation request sent for the related instruction is pending.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PendingReason6Code Value { get; init; }
    }
}
