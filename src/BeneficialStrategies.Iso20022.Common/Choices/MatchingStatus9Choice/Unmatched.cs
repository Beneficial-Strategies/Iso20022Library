// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus9Choice
{
    /// <summary>
    /// Trade is unmatched or mismatched.
    /// </summary>
    [IsoId("_A4aEJtokEeC60axPepSq7g_-830174011")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : MatchingStatus9Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
