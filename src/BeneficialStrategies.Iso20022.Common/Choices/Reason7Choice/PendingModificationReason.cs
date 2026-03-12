// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason7Choice
{
    /// <summary>
    /// Specifies the reason why the modification request is pending.
    /// </summary>
    [IsoId("_E2Dtbf4hEeCH9dkaY_DhYw")]
    [DisplayName("Pending Modification Reason")]
    public partial record PendingModificationReason : Reason7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
