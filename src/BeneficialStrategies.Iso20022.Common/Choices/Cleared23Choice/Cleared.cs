// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared23Choice
{
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_zX2RYQtuEe2eQ-C-GTDpFA")]
    [DisplayName("Cleared")]
    public record Cleared : Cleared23Choice_ { }
}
