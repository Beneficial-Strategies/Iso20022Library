// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraPositionProcessingStatus6Choice
{
    /// <summary>
    /// Instruction has been cancelled.
    /// </summary>
    [IsoId("_5SFAVZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : IntraPositionProcessingStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
