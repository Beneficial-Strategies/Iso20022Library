// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status19Choice
{
    /// <summary>
    /// Provides the status of a securities settlement condition modification request.
    /// </summary>
    [IsoId("_9HwprTqpEeWyoP0PbocV1Q")]
    [DisplayName("Settlement Condition Modification Status")]
    public record SettlementConditionModificationStatus : Status19Choice_ { }
}
