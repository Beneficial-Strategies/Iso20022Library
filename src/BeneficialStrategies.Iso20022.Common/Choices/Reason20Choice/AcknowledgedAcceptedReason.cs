// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason20Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_gAQ5izi8Eeydid5dcNPKvg")]
    [DisplayName("Acknowledged Accepted Reason")]
    public partial record AcknowledgedAcceptedReason : Reason20Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
