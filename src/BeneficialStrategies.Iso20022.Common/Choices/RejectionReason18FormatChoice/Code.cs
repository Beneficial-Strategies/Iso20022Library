// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason18FormatChoice
{
    /// <summary>
    /// Standard code to specify the reason of a rejection of an election advice.
    /// </summary>
    [IsoId("_RoV01Np-Ed-ak6NoX_4Aeg_202927158")]
    [DisplayName("Code")]
    public record Code : RejectionReason18FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of a rejection of an election advice.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason18Code Value { get; init; }
    }
}
