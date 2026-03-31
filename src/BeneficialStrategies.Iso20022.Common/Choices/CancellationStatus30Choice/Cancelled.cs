// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus30Choice
{
    /// <summary>
    /// Specifies the reason why the transaction or instruction is cancelled.
    /// </summary>
    [IsoId("_T_qoARIwEeydmIVkS03esw")]
    [DisplayName("Cancelled")]
    public record Cancelled : CancellationStatus30Choice_ { }
}
