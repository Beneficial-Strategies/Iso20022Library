// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus4Choice
{
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_fmnCc5M5EemKz5EOjv82iQ")]
    [DisplayName("Pending Settlement")]
    public record PendingSettlement : TransferStatus4Choice_ { }
}
