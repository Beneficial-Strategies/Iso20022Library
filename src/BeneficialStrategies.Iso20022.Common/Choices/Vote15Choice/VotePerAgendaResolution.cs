// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Vote15Choice
{
    /// <summary>
    /// Vote instruction is provided individually for each agenda resolution.
    /// </summary>
    [IsoId("_9WxvEfNXEeqRfth943bvEA")]
    [DisplayName("Vote Per Agenda Resolution")]
    public record VotePerAgendaResolution : Vote15Choice_ { }
}
