// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus4Choice
{
    /// <summary>
    /// Modification request is accepted but in repair.
    /// </summary>
    [IsoId("_gvJONVhgEeS8HfHHd4stCA")]
    [DisplayName("Repaired")]
    public partial record Repaired : ModificationProcessingStatus4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
