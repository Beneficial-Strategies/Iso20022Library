// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneratedReasons5Choice
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_OcpIMTqeEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : GeneratedReasons5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the transaction was generated.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GeneratedReason3Code Value { get; init; }
    }
}
