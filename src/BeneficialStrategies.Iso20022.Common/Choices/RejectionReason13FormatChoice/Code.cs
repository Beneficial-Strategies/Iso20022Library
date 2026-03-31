// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason13FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of a movement.
    /// </summary>
    [IsoId("_RoMq49p-Ed-ak6NoX_4Aeg_331296664")]
    [DisplayName("Code")]
    public record Code : RejectionReason13FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of a movement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason13Code Value { get; init; }
    }
}
