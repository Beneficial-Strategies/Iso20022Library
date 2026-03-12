// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus15Choice
{
    /// <summary>
    /// Provides status information related to an instruction request cancelled.
    /// </summary>
    [IsoId("_R-pFEydxEeOXAt_43VmZGw")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : InstructionProcessingStatus15Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
