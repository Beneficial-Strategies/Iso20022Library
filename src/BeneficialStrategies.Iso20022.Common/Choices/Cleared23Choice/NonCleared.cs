// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared23Choice
{
    /// <summary>
    /// Indicates that the contract has not been cleared.
    /// </summary>
    [IsoId("_zX2RZQtuEe2eQ-C-GTDpFA")]
    [DisplayName("Non Cleared")]
    public record NonCleared : Cleared23Choice_ { }
}
