// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus30Choice
{
    /// <summary>
    /// Status is unmatched.
    /// </summary>
    [IsoId("_6QABoZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : MatchingStatus30Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
