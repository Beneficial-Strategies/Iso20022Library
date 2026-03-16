// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus3Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_UWF0htp-Ed-ak6NoX_4Aeg_739185631")]
    [DisplayName("Unmatched")]
    public record Unmatched : MatchingStatus3Choice_ { }
}
