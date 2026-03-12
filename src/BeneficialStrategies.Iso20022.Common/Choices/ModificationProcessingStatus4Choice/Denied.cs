// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus4Choice
{
    /// <summary>
    /// Modification request will not be executed.
    /// </summary>
    [IsoId("_gvJOK1hgEeS8HfHHd4stCA")]
    [DisplayName("Denied")]
    public partial record Denied : ModificationProcessingStatus4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
