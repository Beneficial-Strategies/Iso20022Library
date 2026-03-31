// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FailingReason4Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a failing settlement status.
    /// </summary>
    [IsoId("_Iu4UdxqLEeG38P9Gj2JZJw")]
    [DisplayName("Code")]
    public record Code : FailingReason4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FailingReason3Code Value { get; init; }
    }
}
