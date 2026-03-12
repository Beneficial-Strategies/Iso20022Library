// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus1Choice
{
    /// <summary>
    /// Provides status information related to an instruction request accepted for further processing.
    /// </summary>
    [IsoId("_Qy_hMdp-Ed-ak6NoX_4Aeg_1677583360")]
    [DisplayName("Accepted")]
    public partial record Accepted : InstructionProcessingStatus1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
