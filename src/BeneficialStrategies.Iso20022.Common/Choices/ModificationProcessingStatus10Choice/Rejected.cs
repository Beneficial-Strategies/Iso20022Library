// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus10Choice
{
    /// <summary>
    /// Modification request has been rejected for further processing.
    /// </summary>
    [IsoId("_OqjeIytWEeyhipY4f42fZQ")]
    [DisplayName("Rejected")]
    public partial record Rejected : ModificationProcessingStatus10Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
