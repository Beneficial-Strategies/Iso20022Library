// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus26Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction cancellation request and on the reason for the rejection.
    /// </summary>
    [IsoId("_iKIapbKfEemux5trsZcCpw")]
    [DisplayName("Rejected")]
    public record Rejected : CancellationStatus26Choice_ { }
}
