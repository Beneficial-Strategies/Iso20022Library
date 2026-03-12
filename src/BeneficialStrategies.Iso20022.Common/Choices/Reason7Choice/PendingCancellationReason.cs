// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason7Choice
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_E2DtSf4hEeCH9dkaY_DhYw")]
    [DisplayName("Pending Cancellation Reason")]
    public partial record PendingCancellationReason : Reason7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
