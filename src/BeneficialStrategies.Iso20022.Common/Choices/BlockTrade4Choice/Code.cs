// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BlockTrade4Choice
{
    /// <summary>
    /// Block parent or child information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_2e1tQTqHEeWVrPy0StzzSg")]
    [DisplayName("Code")]
    public record Code : BlockTrade4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the instruction is the parent or a children of a block trade.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BlockTrade1Code Value { get; init; }
    }
}
