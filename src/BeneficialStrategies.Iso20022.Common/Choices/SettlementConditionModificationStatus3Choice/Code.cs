// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementConditionModificationStatus3Choice
{
    /// <summary>
    /// Provides the status of the securities settlement condition modification request.
    /// </summary>
    [IsoId("_9Qt70TqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : SettlementConditionModificationStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a securities settlement condition modification request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementConditionModificationStatus1Code Value { get; init; }
    }
}
