// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AddressType3Choice
{
    /// <summary>
    /// Type of address expressed as a code.
    /// </summary>
    [IsoId("_C7IDQRb-EeiyVv5j1vf1VQ")]
    [DisplayName("Code")]
    public record Code : AddressType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of address.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AddressType2Code Value { get; init; }
    }
}
