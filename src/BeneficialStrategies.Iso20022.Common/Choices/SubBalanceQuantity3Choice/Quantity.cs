// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity3Choice
{
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QYLNfdp-Ed-ak6NoX_4Aeg_-2052781449")]
    [DisplayName("Quantity")]
    public record Quantity : SubBalanceQuantity3Choice_ { }
}
