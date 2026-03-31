// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity4Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off.
    /// </summary>
    [IsoId("_5xlno5NLEeWGlc8L7oPDIg")]
    [DisplayName("Paired Off Quantity")]
    public record PairedOffQuantity : PairedOrTurnedQuantity4Choice_ { }
}
