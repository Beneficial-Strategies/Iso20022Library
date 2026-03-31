// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus4Choice
{
    /// <summary>
    /// Status of the transfer is reversed.
    /// </summary>
    [IsoId("_fmnCf5M5EemKz5EOjv82iQ")]
    [DisplayName("Reversed")]
    public record Reversed : TransferStatus4Choice_ { }
}
