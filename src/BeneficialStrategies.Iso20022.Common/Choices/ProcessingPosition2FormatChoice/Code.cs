// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingPosition2FormatChoice
{
    /// <summary>
    /// Standard code to specify the processing position.
    /// </summary>
    [IsoId("_Rnv-8dp-Ed-ak6NoX_4Aeg_-520028961")]
    [DisplayName("Code")]
    public record Code : ProcessingPosition2FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing position.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingPosition2Code Value { get; init; }
    }
}
