// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus27Choice
{
    /// <summary>
    /// Status applicable globally to the meeting instruction cancellation request message.
    /// </summary>
    [IsoId("_DOiZwMT2Eem9aZlimxVUIw")]
    [DisplayName("Global Cancellation Status")]
    public record GlobalCancellationStatus : CancellationStatus27Choice_ { }
}
