// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus25Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_04af2Tp4EeWVrPy0StzzSg")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : MatchingStatus25Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
