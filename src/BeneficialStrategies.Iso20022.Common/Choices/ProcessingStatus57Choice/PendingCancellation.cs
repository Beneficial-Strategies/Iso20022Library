// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus57Choice
{
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// </summary>
    [IsoId("_6BE0WZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus57Choice_ { }
}
