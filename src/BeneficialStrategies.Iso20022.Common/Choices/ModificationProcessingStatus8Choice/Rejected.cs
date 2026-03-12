// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus8Choice
{
    /// <summary>
    /// Modification request has been rejected for further processing.
    /// </summary>
    [IsoId("_6QCdR5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejected")]
    public partial record Rejected : ModificationProcessingStatus8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
