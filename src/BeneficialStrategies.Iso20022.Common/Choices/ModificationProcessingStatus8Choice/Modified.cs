// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus8Choice
{
    /// <summary>
    /// Instruction has been modified.
    /// </summary>
    [IsoId("_6QCdS5NLEeWGlc8L7oPDIg")]
    [DisplayName("Modified")]
    public record Modified : ModificationProcessingStatus8Choice_ { }
}
