// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Vote13Choice
{
    /// <summary>
    /// One single vote instruction is provided to cover all agenda resolutions.
    /// </summary>
    [IsoId("_3l-70K-4EemJ1NnLPsTFaw")]
    [DisplayName("Vote For All Agenda Resolutions")]
    public partial record VoteForAllAgendaResolutions : Vote13Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
