// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus20Choice
{
    /// <summary>
    /// Instruction/Request will not be executed.
    /// </summary>
    [IsoId("_Mx8yi_4xEeClUvPNHKL9Zw")]
    [DisplayName("Denied")]
    public partial record Denied : ProcessingStatus20Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
