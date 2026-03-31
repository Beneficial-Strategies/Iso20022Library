// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedReason8Choice
{
    /// <summary>
    /// Reason for the accepted status.
    /// </summary>
    [IsoId("_UlpKCVjpEeOnqqBHs8Gasw")]
    [DisplayName("Reason")]
    public record Reason : AcceptedReason8Choice_ { }
}
