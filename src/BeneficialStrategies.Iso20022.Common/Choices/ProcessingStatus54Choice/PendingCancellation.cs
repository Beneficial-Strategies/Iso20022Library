// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus54Choice
{
    /// <summary>
    /// Cancellation is pending processing.
    /// </summary>
    [IsoId("_3eDFUzp4EeWVrPy0StzzSg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus54Choice_ { }
}
