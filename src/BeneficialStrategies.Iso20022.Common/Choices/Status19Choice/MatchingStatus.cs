// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_9HwpoTqpEeWyoP0PbocV1Q")]
    [DisplayName("Matching Status")]
    public partial record MatchingStatus : Status19Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
