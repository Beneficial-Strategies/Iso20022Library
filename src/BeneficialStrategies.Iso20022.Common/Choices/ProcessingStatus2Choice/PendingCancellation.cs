// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus2Choice
{
    /// <summary>
    /// The cancellation is pending processing.
    /// </summary>
    [IsoId("_UUJ60tp-Ed-ak6NoX_4Aeg_1770623718")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus2Choice_ { }
}
