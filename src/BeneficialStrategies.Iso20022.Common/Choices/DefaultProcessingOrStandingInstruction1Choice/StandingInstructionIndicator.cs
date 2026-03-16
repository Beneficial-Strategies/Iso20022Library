// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DefaultProcessingOrStandingInstruction1Choice
{
    /// <summary>
    /// Indicates whether an account owner has placed a standing order to select this corporate action option.
    /// </summary>
    [IsoId("_Q0VlBNp-Ed-ak6NoX_4Aeg_-857961387")]
    [DisplayName("Standing Instruction Indicator")]
    public record StandingInstructionIndicator : DefaultProcessingOrStandingInstruction1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("StgInstrInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
