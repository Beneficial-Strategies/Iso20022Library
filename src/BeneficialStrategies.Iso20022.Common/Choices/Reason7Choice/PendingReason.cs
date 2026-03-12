// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason7Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    [IsoId("_E2DtWf4hEeCH9dkaY_DhYw")]
    [DisplayName("Pending Reason")]
    public partial record PendingReason : Reason7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
