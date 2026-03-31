// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason14Choice
{
    /// <summary>
    /// Specifies the reason why the request was denied.
    /// </summary>
    [IsoId("_2WdbQTqxEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : DeniedReason14Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the denied reason.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DeniedReason7Code Value { get; init; }
    }
}
