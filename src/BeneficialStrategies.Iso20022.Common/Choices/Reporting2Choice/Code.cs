// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reporting2Choice
{
    /// <summary>
    /// Third party reporting information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qs45M9p-Ed-ak6NoX_4Aeg_-290880344")]
    [DisplayName("Code")]
    public record Code : Reporting2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies information with regards to reporting.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Reporting2Code Value { get; init; }
    }
}
