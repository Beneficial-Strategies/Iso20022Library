// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason17Choice
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_8Qc115NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Cancellation Reason")]
    public record PendingCancellationReason : Reason17Choice_ { }
}
