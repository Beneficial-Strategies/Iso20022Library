// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus91Choice
{
    /// <summary>
    /// Modification request will not be executed.
    /// </summary>
    [IsoId("_diXTGTi8Eeydid5dcNPKvg")]
    [DisplayName("Denied")]
    public partial record Denied : ProcessingStatus91Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
