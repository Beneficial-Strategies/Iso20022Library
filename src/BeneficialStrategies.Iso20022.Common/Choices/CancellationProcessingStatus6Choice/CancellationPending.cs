// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus6Choice
{
    /// <summary>
    /// Trade is in cancelation pending.
    /// </summary>
    [IsoId("_A4HJM9okEeC60axPepSq7g_754049523")]
    [DisplayName("Cancellation Pending")]
    public partial record CancellationPending : CancellationProcessingStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
