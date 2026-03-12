// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus8Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction and on the reason for the rejection.
    /// </summary>
    [IsoId("_9DhyVa-nEemJ1NnLPsTFaw")]
    [DisplayName("Rejected")]
    public partial record Rejected : InstructionStatus8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
