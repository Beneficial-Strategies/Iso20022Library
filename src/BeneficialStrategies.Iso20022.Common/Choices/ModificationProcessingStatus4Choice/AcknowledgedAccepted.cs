// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus4Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_gvJOIVhgEeS8HfHHd4stCA")]
    [DisplayName("Acknowledged Accepted")]
    public partial record AcknowledgedAccepted : ModificationProcessingStatus4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
