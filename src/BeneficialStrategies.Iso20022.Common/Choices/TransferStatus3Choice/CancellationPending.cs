// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus3Choice
{
    /// <summary>
    /// Status of the transfer is cancellation pending.
    /// </summary>
    [IsoId("_aeWNYVNUEeijdq8ilaxyOA")]
    [DisplayName("Cancellation Pending")]
    public record CancellationPending : TransferStatus3Choice_ { }
}
