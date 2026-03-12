// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies the reason why the modification request is pending.
    /// </summary>
    [IsoId("_UXlCSdp-Ed-ak6NoX_4Aeg_1017077310")]
    [DisplayName("Pending Modification Reason")]
    public partial record PendingModificationReason : Reason1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
