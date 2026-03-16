// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity1Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be turned.
    /// </summary>
    [IsoId("_UdsRVdp-Ed-ak6NoX_4Aeg_508111545")]
    [DisplayName("Turned Quantity")]
    public record TurnedQuantity : PairedOrTurnedQuantity1Choice_ { }
}
