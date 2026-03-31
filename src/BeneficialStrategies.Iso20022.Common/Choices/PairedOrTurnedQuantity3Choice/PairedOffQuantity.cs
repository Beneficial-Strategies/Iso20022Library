// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PairedOrTurnedQuantity3Choice
{
    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off.
    /// </summary>
    [IsoId("_DzNR0ztCEeWRTLSN0i0tng")]
    [DisplayName("Paired Off Quantity")]
    public record PairedOffQuantity : PairedOrTurnedQuantity3Choice_ { }
}
