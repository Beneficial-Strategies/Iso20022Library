// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason6FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of the notification advice.
    /// </summary>
    [IsoId("_Rofl1tp-Ed-ak6NoX_4Aeg_234326718")]
    [DisplayName("Code")]
    public record Code : RejectionReason6FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of the notification advice.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason6Code Value { get; init; }
    }
}
