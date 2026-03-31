// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RestrictionStatus1Choice
{
    /// <summary>
    /// Status of the restriction expressed as a code.
    /// </summary>
    [IsoId("_cMXWsCFnEeW9XJWqfgXIIA")]
    [DisplayName("Code")]
    public record Code : RestrictionStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a restriction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RestrictionStatus1Code Value { get; init; }
    }
}
