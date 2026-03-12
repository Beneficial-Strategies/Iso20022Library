// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus8Choice
{
    /// <summary>
    /// Modification request is accepted but in repair.
    /// </summary>
    [IsoId("_6QCdSZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repaired")]
    public partial record Repaired : ModificationProcessingStatus8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
