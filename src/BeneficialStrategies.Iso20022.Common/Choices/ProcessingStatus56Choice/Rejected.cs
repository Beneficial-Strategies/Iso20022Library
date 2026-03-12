// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus56Choice
{
    /// <summary>
    /// Instruction is rejected.
    /// </summary>
    [IsoId("_db1M0Tt5EeW638lNyHKv7A")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus56Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
