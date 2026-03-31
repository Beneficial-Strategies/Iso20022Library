// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus42Choice
{
    /// <summary>
    /// Transaction was created by the account servicer or a third party. It was not instructed directly by the account owner.
    /// </summary>
    [IsoId("_7X_7IQpJEeup4r-PFG2T5Q")]
    [DisplayName("Generated")]
    public record Generated : InstructionProcessingStatus42Choice_ { }
}
