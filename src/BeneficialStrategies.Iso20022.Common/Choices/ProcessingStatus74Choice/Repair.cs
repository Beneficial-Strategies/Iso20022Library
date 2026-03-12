// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus74Choice
{
    /// <summary>
    /// Instruction/request is accepted but in repair.
    /// </summary>
    [IsoId("_GcCjHdB7EeihG9bKfarOOA")]
    [DisplayName("Repair")]
    public partial record Repair : ProcessingStatus74Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
