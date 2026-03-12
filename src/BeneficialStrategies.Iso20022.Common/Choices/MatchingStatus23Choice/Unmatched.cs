// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus23Choice
{
    /// <summary>
    /// Trade is unmatched or mismatched.
    /// </summary>
    [IsoId("_1Bk5h2XREeOWzsrIp2keDA")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : MatchingStatus23Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
