// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus26Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction cancellation request and on the reason for the rejection.
    /// </summary>
    [IsoId("_iKIapbKfEemux5trsZcCpw")]
    [DisplayName("Rejected")]
    public partial record Rejected : CancellationStatus26Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
