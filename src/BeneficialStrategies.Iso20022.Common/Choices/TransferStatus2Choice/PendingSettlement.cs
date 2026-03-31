// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus2Choice
{
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_aQ-GMyY3EeW_ZNn8gbfY7Q")]
    [DisplayName("Pending Settlement")]
    public record PendingSettlement : TransferStatus2Choice_ { }
}
