// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus7Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_GJDzAf5WEeCtrO5qCU90cA")]
    [DisplayName("Unmatched")]
    public record Unmatched : MatchingStatus7Choice_ { }
}
