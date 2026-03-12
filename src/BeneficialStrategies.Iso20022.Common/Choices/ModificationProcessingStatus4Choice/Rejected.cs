// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus4Choice
{
    /// <summary>
    /// Modification request has been rejected for further processing.
    /// </summary>
    [IsoId("_gvJOM1hgEeS8HfHHd4stCA")]
    [DisplayName("Rejected")]
    public partial record Rejected : ModificationProcessingStatus4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
