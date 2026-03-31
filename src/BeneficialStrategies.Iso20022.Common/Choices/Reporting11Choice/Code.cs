// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reporting11Choice
{
    /// <summary>
    /// Third party reporting information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_6sleCffVEeiNZp_PtLohLw")]
    [DisplayName("Code")]
    public record Code : Reporting11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies to which institution the reporting must be done.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Reporting3Code Value { get; init; }
    }
}
