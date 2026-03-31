// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason8Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_tg-hClj7EeOgwYxfAV02bg")]
    [DisplayName("Reason")]
    public record Reason : RejectedReason8Choice_ { }
}
