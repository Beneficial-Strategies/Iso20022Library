// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus6Choice
{
    /// <summary>
    /// Trade is in cancelation pending.
    /// </summary>
    [IsoId("_A4HJM9okEeC60axPepSq7g_754049523")]
    [DisplayName("Cancellation Pending")]
    public record CancellationPending : CancellationProcessingStatus6Choice_ { }
}
