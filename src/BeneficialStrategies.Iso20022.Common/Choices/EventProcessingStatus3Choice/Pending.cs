// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EventProcessingStatus3Choice
{
    /// <summary>
    /// Specifies that a corporate action event processing has not been fully completed and is therefore pending.
    /// </summary>
    [IsoId("_tDTUsUGSEeWqy4niLuXETA")]
    [DisplayName("Pending")]
    public partial record Pending : EventProcessingStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
