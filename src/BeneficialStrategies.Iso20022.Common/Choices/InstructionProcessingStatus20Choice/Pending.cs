// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus20Choice
{
    /// <summary>
    /// Provides status information related to a pending instruction.
    /// </summary>
    [IsoId("_inrWy1hYEeSewsfsZR0hxA")]
    [DisplayName("Pending")]
    public partial record Pending : InstructionProcessingStatus20Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
