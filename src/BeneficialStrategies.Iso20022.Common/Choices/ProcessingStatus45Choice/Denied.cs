// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus45Choice
{
    /// <summary>
    /// Instruction/Request will not be executed.
    /// </summary>
    [IsoId("_i0ct61hgEeS8HfHHd4stCA")]
    [DisplayName("Denied")]
    public partial record Denied : ProcessingStatus45Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
