// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessedStatus5FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing status of a request.
    /// </summary>
    [IsoId("_RnmN89p-Ed-ak6NoX_4Aeg_-2007876597")]
    [DisplayName("Code")]
    public record Code : ProcessedStatus5FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of a request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessedStatus5Code Value { get; init; }
    }
}
