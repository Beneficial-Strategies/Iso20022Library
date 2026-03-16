// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus2Choice
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// </summary>
    [IsoId("_UZ9n4tp-Ed-ak6NoX_4Aeg_-471752923")]
    [DisplayName("Pending")]
    public record Pending : SettlementStatus2Choice_ { }
}
