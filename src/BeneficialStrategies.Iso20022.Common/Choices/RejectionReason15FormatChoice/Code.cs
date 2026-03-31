// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason15FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of an information advice.
    /// </summary>
    [IsoId("_RoV00dp-Ed-ak6NoX_4Aeg_356231670")]
    [DisplayName("Code")]
    public record Code : RejectionReason15FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of an information advice.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason15Code Value { get; init; }
    }
}
