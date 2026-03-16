// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason7Choice
{
    /// <summary>
    /// Specifies the reason why the modification request is pending.
    /// </summary>
    [IsoId("_E2Dtbf4hEeCH9dkaY_DhYw")]
    [DisplayName("Pending Modification Reason")]
    public record PendingModificationReason : Reason7Choice_ { }
}
