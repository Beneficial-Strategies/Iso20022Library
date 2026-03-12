// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus5Choice
{
    /// <summary>
    /// Modification request will not be executed.
    /// </summary>
    [IsoId("_UUvwsNp-Ed-ak6NoX_4Aeg_1371540313")]
    [DisplayName("Denied")]
    public partial record Denied : ProcessingStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
