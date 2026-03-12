// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus80Choice
{
    /// <summary>
    /// Instruction/request has been rejected for further processing.
    /// </summary>
    [IsoId("_6icMGQpJEeup4r-PFG2T5Q")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus80Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
