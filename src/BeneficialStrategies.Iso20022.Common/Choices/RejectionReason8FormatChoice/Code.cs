// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason8FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of an election amendment request.
    /// </summary>
    [IsoId("_Roovw9p-Ed-ak6NoX_4Aeg_274039681")]
    [DisplayName("Code")]
    public record Code : RejectionReason8FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of an election amendment request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason8Code Value { get; init; }
    }
}
