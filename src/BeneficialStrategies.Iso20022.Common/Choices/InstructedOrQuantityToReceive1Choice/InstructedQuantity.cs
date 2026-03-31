// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructedOrQuantityToReceive1Choice
{
    /// <summary>
    /// Quantity of underlying securities to which this instruction applies.
    /// </summary>
    [IsoId("_UHCr6tp-Ed-ak6NoX_4Aeg_-1856405230")]
    [DisplayName("Instructed Quantity")]
    public record InstructedQuantity : InstructedOrQuantityToReceive1Choice_ { }
}
