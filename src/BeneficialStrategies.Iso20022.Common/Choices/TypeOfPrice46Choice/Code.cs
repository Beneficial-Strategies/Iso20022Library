// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfPrice46Choice
{
    /// <summary>
    /// Type expressed as a code.
    /// </summary>
    [IsoId("_JNG9gjhgEeamLZQeccJa7w")]
    [DisplayName("Code")]
    public record Code : TypeOfPrice46Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of price.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfPrice10Code Value { get; init; }
    }
}
