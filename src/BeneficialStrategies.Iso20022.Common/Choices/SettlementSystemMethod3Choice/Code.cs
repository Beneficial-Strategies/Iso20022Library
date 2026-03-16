// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementSystemMethod3Choice
{
    /// <summary>
    /// Settlement system expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AZQqAtokEeC60axPepSq7g_1835562004")]
    [DisplayName("Code")]
    public record Code : SettlementSystemMethod3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementSystemMethod1Code Value { get; init; }
    }
}
