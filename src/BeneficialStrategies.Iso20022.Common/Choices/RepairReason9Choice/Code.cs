// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepairReason9Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_A5mW8dokEeC60axPepSq7g_-1578986183")]
    [DisplayName("Code")]
    public record Code : RepairReason9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction is in repair.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepairReason7Code Value { get; init; }
    }
}
