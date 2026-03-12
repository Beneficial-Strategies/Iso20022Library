// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus65Choice
{
    /// <summary>
    /// Cancellation is pending processing.
    /// </summary>
    [IsoId("_8SdA_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : ProcessingStatus65Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
