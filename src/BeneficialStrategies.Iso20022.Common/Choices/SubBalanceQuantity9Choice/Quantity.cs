// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity9Choice
{
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_ciAo3zi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    public record Quantity : SubBalanceQuantity9Choice_ { }
}
