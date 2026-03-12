// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedReason8Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_tg-hClj7EeOgwYxfAV02bg")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedReason8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
