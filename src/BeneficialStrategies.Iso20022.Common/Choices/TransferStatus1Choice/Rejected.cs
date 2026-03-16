// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is rejected.
    /// </summary>
    [IsoId("_o1CqrBwkEeOIveEnnb_1-A")]
    [DisplayName("Rejected")]
    public record Rejected : TransferStatus1Choice_ { }
}
