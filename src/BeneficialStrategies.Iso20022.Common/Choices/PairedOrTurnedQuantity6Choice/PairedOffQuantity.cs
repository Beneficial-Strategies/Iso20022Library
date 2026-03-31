// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity6Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off.
    /// </summary>
    [IsoId("_dJccjzi8Eeydid5dcNPKvg")]
    [DisplayName("Paired Off Quantity")]
    public record PairedOffQuantity : PairedOrTurnedQuantity6Choice_ { }
}
