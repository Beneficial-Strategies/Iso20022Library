// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason20FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of the standing instruction request.
    /// </summary>
    [IsoId("_Rofl09p-Ed-ak6NoX_4Aeg_227864528")]
    [DisplayName("Code")]
    public record Code : RejectionReason20FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of the standing instruction request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason20Code Value { get; init; }
    }
}
