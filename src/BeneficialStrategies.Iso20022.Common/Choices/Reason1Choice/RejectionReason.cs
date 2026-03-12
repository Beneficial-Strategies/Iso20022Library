// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected status.
    /// </summary>
    [IsoId("_UXlCR9p-Ed-ak6NoX_4Aeg_-1386433393")]
    [DisplayName("Rejection Reason")]
    public partial record RejectionReason : Reason1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
