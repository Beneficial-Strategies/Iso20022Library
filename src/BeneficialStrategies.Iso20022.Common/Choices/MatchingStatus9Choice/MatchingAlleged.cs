// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus9Choice
{
    /// <summary>
    /// Trade is matched alleged.
    /// </summary>
    [IsoId("_A4aEJdokEeC60axPepSq7g_-548171408")]
    [DisplayName("Matching Alleged")]
    public record MatchingAlleged : MatchingStatus9Choice_ { }
}
