// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason16Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected status.
    /// </summary>
    [IsoId("_kYkAhTnvEeWfSKvvZlhRKg")]
    [DisplayName("Rejection Reason")]
    public partial record RejectionReason : Reason16Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
