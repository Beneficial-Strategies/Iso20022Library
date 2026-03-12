// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus10Choice
{
    /// <summary>
    /// Modification is pending processing.
    /// </summary>
    [IsoId("_OqjeGStWEeyhipY4f42fZQ")]
    [DisplayName("Pending Processing")]
    public partial record PendingProcessing : ModificationProcessingStatus10Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
