// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus30Choice
{
    /// <summary>
    /// Provides status information related to a pending instruction.
    /// </summary>
    [IsoId("_komxxZwsEeazcsnODTksnQ")]
    [DisplayName("Pending")]
    public partial record Pending : InstructionProcessingStatus30Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
