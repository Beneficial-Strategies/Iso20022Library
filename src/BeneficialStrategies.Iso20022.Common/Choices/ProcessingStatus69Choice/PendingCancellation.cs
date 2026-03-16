// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus69Choice
{
    /// <summary>
    /// Cancellation is pending processing.
    /// </summary>
    [IsoId("_1y2s8eF7EeWCAvUNsZ5u6g")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus69Choice_ { }
}
