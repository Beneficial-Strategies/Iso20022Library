// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus6Choice
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_mdrUkTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Consented")]
    public record Consented : ResponseStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cnsntd")]
        public required ConsentStatus4Choice_ Value { get; init; }
    }
}
