// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance4Choice
{
    /// <summary>
    /// Opening balance for the statement period. It always equals the closing balance of the previous statement.
    /// </summary>
    [IsoId("_NnIMoTnGEeWV5sr121Fc8A")]
    [DisplayName("First")]
    public record First : OpeningBalance4Choice_ { }
}
