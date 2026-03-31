// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus92Choice
{
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// </summary>
    [IsoId("_dsyacDi8Eeydid5dcNPKvg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus92Choice_ { }
}
