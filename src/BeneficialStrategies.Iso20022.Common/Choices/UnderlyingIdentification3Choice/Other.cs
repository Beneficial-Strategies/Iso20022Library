// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingIdentification3Choice
{
    /// <summary>
    /// Underlying of any other type of transaction.
    /// </summary>
    [IsoId("_2EZuE53DEeuwmdq0KtnICg")]
    [DisplayName("Other")]
    public record Other : UnderlyingIdentification3Choice_ { }
}
