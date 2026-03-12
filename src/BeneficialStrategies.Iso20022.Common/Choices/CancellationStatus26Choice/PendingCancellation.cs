// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus26Choice
{
    /// <summary>
    /// Status advising that the instruction cancellation request is pending and advising on the reason for the pending status.
    /// </summary>
    [IsoId("_7I3wILKfEemux5trsZcCpw")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : CancellationStatus26Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
