// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus45Choice
{
    /// <summary>
    /// Instruction/Request has been rejected for further processing.
    /// </summary>
    [IsoId("_i0cty1hgEeS8HfHHd4stCA")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus45Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
