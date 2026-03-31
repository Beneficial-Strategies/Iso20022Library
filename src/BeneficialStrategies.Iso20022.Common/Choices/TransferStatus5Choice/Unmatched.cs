// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus5Choice
{
    /// <summary>
    /// Status of the transfer is unmatched.
    /// </summary>
    [IsoId("_WY1VReijEeuLe8v4JEtDDg")]
    [DisplayName("Unmatched")]
    public record Unmatched : TransferStatus5Choice_ { }
}
