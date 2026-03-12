// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus67Choice
{
    /// <summary>
    /// Instruction or request is accepted but in repair.
    /// </summary>
    [IsoId("_XD6lKeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Repair")]
    public partial record Repair : ProcessingStatus67Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
