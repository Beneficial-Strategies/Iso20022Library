// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason14Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    [IsoId("_ux5oL1hpEeS8HfHHd4stCA")]
    [DisplayName("Pending Reason")]
    public partial record PendingReason : Reason14Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
