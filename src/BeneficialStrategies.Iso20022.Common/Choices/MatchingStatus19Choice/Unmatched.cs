// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus19Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_Z-Yo2SwREeOEV5XHD-BKpw")]
    [DisplayName("Unmatched")]
    public record Unmatched : MatchingStatus19Choice_ { }
}
