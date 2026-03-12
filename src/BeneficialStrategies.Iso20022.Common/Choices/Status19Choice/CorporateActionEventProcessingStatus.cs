// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Provides the status of a corporate action or the status of a payment.
    /// </summary>
    [IsoId("_9HwpmTqpEeWyoP0PbocV1Q")]
    [DisplayName("Corporate Action Event Processing Status")]
    public partial record CorporateActionEventProcessingStatus : Status19Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
