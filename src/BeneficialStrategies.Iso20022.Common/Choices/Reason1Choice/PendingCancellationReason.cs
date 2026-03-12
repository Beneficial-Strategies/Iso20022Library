// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_UXlCQNp-Ed-ak6NoX_4Aeg_-251158629")]
    [DisplayName("Pending Cancellation Reason")]
    public partial record PendingCancellationReason : Reason1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
