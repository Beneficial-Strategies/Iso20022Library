// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus35Choice
{
    /// <summary>
    /// Trade is unmatched or mismatched.
    /// </summary>
    [IsoId("_2sTZ9wd3Ee2fOITqoTnSLQ")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : MatchingStatus35Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
