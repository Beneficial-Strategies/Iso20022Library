// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionAndRepairReason2Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_UWrqY9p-Ed-ak6NoX_4Aeg_1851323757")]
    [DisplayName("Code")]
    public record Code : RejectionAndRepairReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the request has a rejected or repair status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason24Code Value { get; init; }
    }
}
