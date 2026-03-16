// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus30Choice
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// </summary>
    [IsoId("_dCK7kyW-EeygjNFjAlVoPA")]
    [DisplayName("Pending")]
    public record Pending : SettlementStatus30Choice_ { }
}
