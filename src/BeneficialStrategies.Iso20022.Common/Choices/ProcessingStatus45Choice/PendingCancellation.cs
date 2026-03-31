// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus45Choice
{
    /// <summary>
    /// The cancellation is pending processing.
    /// </summary>
    [IsoId("_i0ctw1hgEeS8HfHHd4stCA")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus45Choice_ { }
}
