// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AllegementReason1Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    [IsoId("_mkVM0WXREeOWzsrIp2keDA")]
    [DisplayName("Code")]
    public record Code : AllegementReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction has an allegement status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AllegementReason1Code Value { get; init; }
    }
}
