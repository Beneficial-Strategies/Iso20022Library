// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStandingInstructionDatabase3Choice
{
    /// <summary>
    /// Settlement standing instruction database expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AbgFsNokEeC60axPepSq7g_-1180537680")]
    [DisplayName("Code")]
    public record Code : SettlementStandingInstructionDatabase3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementStandingInstructionDatabase1Code Value { get; init; }
    }
}
