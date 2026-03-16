// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnershipType3Choice
{
    /// <summary>
    /// Owner type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_pl-wkIzhEemXJvzC2Wyt1g")]
    [DisplayName("Code")]
    public record Code : OwnershipType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of account ownership.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountOwnershipType5Code Value { get; init; }
    }
}
