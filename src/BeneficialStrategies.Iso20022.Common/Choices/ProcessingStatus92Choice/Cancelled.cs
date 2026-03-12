// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus92Choice
{
    /// <summary>
    /// Instruction has been cancelled.
    /// </summary>
    [IsoId("_dsyaaDi8Eeydid5dcNPKvg")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : ProcessingStatus92Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
