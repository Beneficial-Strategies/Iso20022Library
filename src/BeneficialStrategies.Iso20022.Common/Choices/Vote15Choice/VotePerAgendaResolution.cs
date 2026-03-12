// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Vote15Choice
{
    /// <summary>
    /// Vote instruction is provided individually for each agenda resolution.
    /// </summary>
    [IsoId("_9WxvEfNXEeqRfth943bvEA")]
    [DisplayName("Vote Per Agenda Resolution")]
    public partial record VotePerAgendaResolution : Vote15Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
