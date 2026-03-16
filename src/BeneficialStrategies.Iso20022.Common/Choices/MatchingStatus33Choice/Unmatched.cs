// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus33Choice
{
    /// <summary>
    /// Instruction has not been matched.
    /// </summary>
    [IsoId("_LuVKgOB-Eei2UYJ62ws-Fw")]
    [DisplayName("Unmatched")]
    public record Unmatched : MatchingStatus33Choice_ { }
}
