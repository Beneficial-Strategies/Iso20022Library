// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus69Choice
{
    /// <summary>
    /// Cancellation requested executed.
    /// </summary>
    [IsoId("_1y2tIeF7EeWCAvUNsZ5u6g")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus69Choice_ { }
}
