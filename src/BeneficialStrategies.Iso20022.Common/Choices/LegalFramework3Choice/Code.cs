// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LegalFramework3Choice
{
    /// <summary>
    /// Legal framework expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("__YvnATqkEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : LegalFramework3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the legal framework of the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LegalFramework1Code Value { get; init; }
    }
}
