// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus32Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_6d8XUZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched")]
    public record Unmatched : MatchingStatus32Choice_ { }
}
