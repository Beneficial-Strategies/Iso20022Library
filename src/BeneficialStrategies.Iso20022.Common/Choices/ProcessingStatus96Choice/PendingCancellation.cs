// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus96Choice
{
    /// <summary>
    /// Cancellation is pending processing.
    /// </summary>
    [IsoId("_gBzJazi8Eeydid5dcNPKvg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus96Choice_ { }
}
