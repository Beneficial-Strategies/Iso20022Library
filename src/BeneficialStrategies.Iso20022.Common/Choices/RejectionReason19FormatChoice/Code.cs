// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason19FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of a global movement authorisation request.
    /// </summary>
    [IsoId("_Rofl0Np-Ed-ak6NoX_4Aeg_216780374")]
    [DisplayName("Code")]
    public record Code : RejectionReason19FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of a global movement authorisation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason19Code Value { get; init; }
    }
}
