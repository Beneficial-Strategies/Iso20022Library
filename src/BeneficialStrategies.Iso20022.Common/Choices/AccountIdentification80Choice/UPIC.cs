// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification80Choice
{
    /// <summary>
    /// UPIC.
    /// </summary>
    [DisplayName("UPIC")]
    public record UPIC : AccountIdentification80Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("UPIC")]
        public required IsoUPICIdentifier Value { get; init; }
    }
}
