// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus82Choice
{
    /// <summary>
    /// Cancellation request is pending on the instruction.
    /// </summary>
    [IsoId("_FjyNSRIwEeydmIVkS03esw")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : ProcessingStatus82Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
