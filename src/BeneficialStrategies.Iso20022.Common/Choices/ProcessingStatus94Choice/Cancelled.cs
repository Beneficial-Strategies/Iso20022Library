// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus94Choice
{
    /// <summary>
    /// Instruction/request has been cancelled.
    /// </summary>
    [IsoId("_f979Nzi8Eeydid5dcNPKvg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus94Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
