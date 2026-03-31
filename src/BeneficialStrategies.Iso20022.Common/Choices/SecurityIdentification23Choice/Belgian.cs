// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Identifier for Belgian securities.
    /// </summary>
    [IsoId("_CSq4SyGQEeW7gKYhAMEFCw")]
    [DisplayName("Belgian")]
    public record Belgian : SecurityIdentification23Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for Belgian securities.
        /// </summary>
        [IsoXmlTag("Belgn")]
        [IsoSimpleType(IsoSimpleType.BelgianIdentifier)]
        public required IsoBelgianIdentifier Value { get; init; }
    }
}
