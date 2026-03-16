// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reporting7Choice
{
    /// <summary>
    /// Third party reporting information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_vZnKgTxJEeW5v6FXICU4Ew")]
    [DisplayName("Code")]
    public record Code : Reporting7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies to which institution the reporting must be done.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Reporting1Code Value { get; init; }
    }
}
