// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReceivedReason1Choice
{
    /// <summary>
    /// Reason for the received status.
    /// </summary>
    [IsoId("_9wz1b1jqEeOnqqBHs8Gasw")]
    [DisplayName("Reason")]
    public record Reason : ReceivedReason1Choice_ { }
}
