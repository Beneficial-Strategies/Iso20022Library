// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient15Choice
{
    /// <summary>
    /// KEK.
    /// </summary>
    [DisplayName("KEK")]
    public record KEK : Recipient15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("KEK")]
        public required KEK9 Value { get; init; }
    }
}
