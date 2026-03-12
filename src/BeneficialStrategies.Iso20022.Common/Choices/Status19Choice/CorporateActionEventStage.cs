// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_9HwpmzqpEeWyoP0PbocV1Q")]
    [DisplayName("Corporate Action Event Stage")]
    public partial record CorporateActionEventStage : Status19Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
