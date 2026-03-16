// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity10Choice
{
    /// <summary>
    /// Quantity of financial instrument in units, original face amount or current face amount.
    /// </summary>
    [IsoId("_WsJF5Np-Ed-ak6NoX_4Aeg_2145706527")]
    [DisplayName("Quantity")]
    public record Quantity : Quantity10Choice_ { }
}
