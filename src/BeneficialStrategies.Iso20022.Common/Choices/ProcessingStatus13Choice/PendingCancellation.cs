// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus13Choice
{
    /// <summary>
    /// The cancellation is pending processing.
    /// </summary>
    [IsoId("_ZH-k4-ZgEd-q8fx_Zl_34A")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus13Choice_ { }
}
