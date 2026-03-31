// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason9Choice
{
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_6LbpKlj1EeOnqqBHs8Gasw")]
    [DisplayName("Reason")]
    public record Reason : PendingProcessingReason9Choice_ { }
}
