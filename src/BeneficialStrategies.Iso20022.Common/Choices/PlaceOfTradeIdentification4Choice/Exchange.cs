// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification4Choice
{
    /// <summary>
    /// Exchange.
    /// </summary>
    [DisplayName("Exchange")]
    public record Exchange : PlaceOfTradeIdentification4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Xchg")]
        public required IsoMICIdentifier Value { get; init; }
    }
}
