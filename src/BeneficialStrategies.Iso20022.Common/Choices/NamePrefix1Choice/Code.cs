// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NamePrefix1Choice
{
    /// <summary>
    /// Name prefix expressed as a code.
    /// </summary>
    [IsoId("_5MAtECiEEeKVDZ5HKjI6bg")]
    [DisplayName("Code")]
    public record Code : NamePrefix1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the terms used to formally address a person.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required NamePrefix1Code Value { get; init; }
    }
}
