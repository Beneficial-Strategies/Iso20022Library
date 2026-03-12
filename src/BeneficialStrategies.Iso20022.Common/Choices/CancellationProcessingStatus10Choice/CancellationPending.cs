// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus10Choice
{
    /// <summary>
    /// Trade is in cancelation pending.
    /// </summary>
    [IsoId("_l0B_0Qd4Ee2fOITqoTnSLQ")]
    [DisplayName("Cancellation Pending")]
    public partial record CancellationPending : CancellationProcessingStatus10Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
