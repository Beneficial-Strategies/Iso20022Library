// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus69Choice
{
    /// <summary>
    /// Instruction/Request will not be executed.
    /// </summary>
    [IsoId("_1y2tGeF7EeWCAvUNsZ5u6g")]
    [DisplayName("Denied")]
    public partial record Denied : ProcessingStatus69Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
