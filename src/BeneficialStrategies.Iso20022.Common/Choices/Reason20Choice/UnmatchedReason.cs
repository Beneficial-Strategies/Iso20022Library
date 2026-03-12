// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason20Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_gAQ5mTi8Eeydid5dcNPKvg")]
    [DisplayName("Unmatched Reason")]
    public partial record UnmatchedReason : Reason20Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
