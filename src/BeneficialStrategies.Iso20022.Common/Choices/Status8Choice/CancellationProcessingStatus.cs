// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of a cancellation request.
    /// </summary>
    [IsoId("_w2B8AUABEeCaq78Ig8ATcA")]
    [DisplayName("Cancellation Processing Status")]
    public partial record CancellationProcessingStatus : Status8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
