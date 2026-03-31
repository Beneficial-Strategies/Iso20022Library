// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus23Choice
{
    /// <summary>
    /// Trade is matched alleged.
    /// </summary>
    [IsoId("_1Bk5hWXREeOWzsrIp2keDA")]
    [DisplayName("Matching Alleged")]
    public record MatchingAlleged : MatchingStatus23Choice_ { }
}
