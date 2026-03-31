// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus23Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_cDgJATqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : InstructionProcessingStatus23Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InstructionProcessingStatus1Code Value { get; init; }
    }
}
