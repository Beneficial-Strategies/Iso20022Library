// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Appearance3Choice
{
    /// <summary>
    /// Appearance expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_dhNzEeLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public record Code : Appearance3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the deliverability of a security.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Appearance1Code Value { get; init; }
    }
}
