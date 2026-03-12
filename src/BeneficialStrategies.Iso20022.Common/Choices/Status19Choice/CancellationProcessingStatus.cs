// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Provides the status of a cancellation request.
    /// </summary>
    [IsoId("_9HwpqTqpEeWyoP0PbocV1Q")]
    [DisplayName("Cancellation Processing Status")]
    public partial record CancellationProcessingStatus : Status19Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
