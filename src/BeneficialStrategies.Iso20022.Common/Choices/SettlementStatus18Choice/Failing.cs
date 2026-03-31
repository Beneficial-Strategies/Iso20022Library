// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus18Choice
{
    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// </summary>
    [IsoId("_2dIa6zp4EeWVrPy0StzzSg")]
    [DisplayName("Failing")]
    public record Failing : SettlementStatus18Choice_ { }
}
