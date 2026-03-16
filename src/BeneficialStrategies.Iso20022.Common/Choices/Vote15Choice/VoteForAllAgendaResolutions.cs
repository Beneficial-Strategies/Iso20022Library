// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Vote15Choice
{
    /// <summary>
    /// One single vote instruction is provided to cover all agenda resolutions.
    /// </summary>
    [IsoId("_9WxvE_NXEeqRfth943bvEA")]
    [DisplayName("Vote For All Agenda Resolutions")]
    public record VoteForAllAgendaResolutions : Vote15Choice_ { }
}
