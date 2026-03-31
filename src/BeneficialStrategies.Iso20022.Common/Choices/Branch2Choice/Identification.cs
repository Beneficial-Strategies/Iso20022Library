// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Branch2Choice
{
    /// <summary>
    /// Identification of the branch office of a reporting counterparty.
    /// </summary>
    [IsoId("_6YyU4UqQEeeLKviVB0vAnA")]
    [DisplayName("Identification")]
    public record Identification : Branch2Choice_ { }
}
