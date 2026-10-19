// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason7Choice
{
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    [IsoId("_E2DtSf4hEeCH9dkaY_DhYw")]
    [DisplayName("Pending Cancellation Reason")]
    public partial record PendingCancellationReason : Reason7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgCxlRsn")]
        public required PendingCancellationReasons2Choice_ Value { get; init; }
    }
}
