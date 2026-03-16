// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Branch5Choice
{
    /// <summary>
    /// Identification of the branch office of a reporting counterparty.
    /// </summary>
    [IsoId("_Brx1ccg4Eeu4ecZgAYuz5w")]
    [DisplayName("Identification")]
    public record Identification : Branch5Choice_ { }
}
