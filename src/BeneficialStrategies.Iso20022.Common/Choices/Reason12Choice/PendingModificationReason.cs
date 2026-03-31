// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason12Choice
{
    /// <summary>
    /// Specifies the reason why the modification request is pending.
    /// </summary>
    [IsoId("_C2YFySRhEeO8sskhVI3IDA")]
    [DisplayName("Pending Modification Reason")]
    public record PendingModificationReason : Reason12Choice_ { }
}
