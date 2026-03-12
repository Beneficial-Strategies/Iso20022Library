// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus20Choice
{
    /// <summary>
    /// The cancellation is pending processing.
    /// </summary>
    [IsoId("_Mx8yWf4xEeClUvPNHKL9Zw")]
    [DisplayName("Pending Cancellation")]
    public partial record PendingCancellation : ProcessingStatus20Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
