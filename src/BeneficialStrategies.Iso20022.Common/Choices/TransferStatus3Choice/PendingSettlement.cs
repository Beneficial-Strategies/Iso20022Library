// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus3Choice
{
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_aeWNU1NUEeijdq8ilaxyOA")]
    [DisplayName("Pending Settlement")]
    public record PendingSettlement : TransferStatus3Choice_ { }
}
