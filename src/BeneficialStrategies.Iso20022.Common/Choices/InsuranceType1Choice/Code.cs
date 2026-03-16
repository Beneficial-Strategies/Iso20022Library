// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InsuranceType1Choice
{
    /// <summary>
    /// Type of insurance contract expressed as a code.
    /// </summary>
    [IsoId("_vPyssBQZEeKebsB9eKJSkA")]
    [DisplayName("Code")]
    public record Code : InsuranceType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of insurance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Insurance1Code Value { get; init; }
    }
}
