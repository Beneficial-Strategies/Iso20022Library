// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfPrice29Choice
{
    /// <summary>
    /// Type of price expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_RBB38znXEeWV5sr121Fc8A")]
    [DisplayName("Code")]
    public record Code : TypeOfPrice29Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of transaction price.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfPrice14Code Value { get; init; }
    }
}
