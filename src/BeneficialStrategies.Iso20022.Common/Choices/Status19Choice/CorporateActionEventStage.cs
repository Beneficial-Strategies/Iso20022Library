// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_9HwpmzqpEeWyoP0PbocV1Q")]
    [DisplayName("Corporate Action Event Stage")]
    public record CorporateActionEventStage : Status19Choice_ { }
}
