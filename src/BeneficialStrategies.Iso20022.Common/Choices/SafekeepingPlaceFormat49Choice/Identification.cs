// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat49Choice
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    public record Identification : SafekeepingPlaceFormat49Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Id")]
        public required SafekeepingPlaceTypeAndText9 Value { get; init; }
    }
}
