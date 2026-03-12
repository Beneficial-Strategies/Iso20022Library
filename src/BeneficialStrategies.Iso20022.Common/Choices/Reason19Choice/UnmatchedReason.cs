// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason19Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_8NNHKytXEeyhipY4f42fZQ")]
    [DisplayName("Unmatched Reason")]
    public partial record UnmatchedReason : Reason19Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
