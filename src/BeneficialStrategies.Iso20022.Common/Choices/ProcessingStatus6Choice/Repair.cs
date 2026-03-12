// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus6Choice
{
    /// <summary>
    /// Instruction/Request is accepted but in repair.
    /// </summary>
    [IsoId("_UVMcp9p-Ed-ak6NoX_4Aeg_-747897571")]
    [DisplayName("Repair")]
    public partial record Repair : ProcessingStatus6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
