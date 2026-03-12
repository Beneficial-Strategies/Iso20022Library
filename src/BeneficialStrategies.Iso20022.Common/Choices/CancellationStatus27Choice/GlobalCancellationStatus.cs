// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus27Choice
{
    /// <summary>
    /// Status applicable globally to the meeting instruction cancellation request message.
    /// </summary>
    [IsoId("_DOiZwMT2Eem9aZlimxVUIw")]
    [DisplayName("Global Cancellation Status")]
    public partial record GlobalCancellationStatus : CancellationStatus27Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
