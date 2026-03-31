// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementInstructionGeneration1Choice
{
    /// <summary>
    /// Settlement instruction generation expressed as a ISO20022 code.
    /// </summary>
    [IsoId("_AbMjs9okEeC60axPepSq7g_-143457824")]
    [DisplayName("Code")]
    public record Code : SettlementInstructionGeneration1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Settlement Instruction Generation Code.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementInstructionGeneration1Code Value { get; init; }
    }
}
