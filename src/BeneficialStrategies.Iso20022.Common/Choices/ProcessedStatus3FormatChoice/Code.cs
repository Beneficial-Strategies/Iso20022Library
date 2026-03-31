// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus3FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing status of an advice, a request or a movement.
    /// </summary>
    [IsoId("_RnTTBdp-Ed-ak6NoX_4Aeg_-735203961")]
    [DisplayName("Code")]
    public record Code : ProcessedStatus3FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of an advice, a request or a movement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessedStatus3Code Value { get; init; }
    }
}
