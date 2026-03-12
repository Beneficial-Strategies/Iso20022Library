// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason12Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a failing settlement status.
    /// </summary>
    [IsoId("_C2YFwSRhEeO8sskhVI3IDA")]
    [DisplayName("Failing Reason")]
    public partial record FailingReason : Reason12Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
