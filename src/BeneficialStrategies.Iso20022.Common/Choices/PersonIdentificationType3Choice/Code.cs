// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType3Choice
{
    /// <summary>
    /// Person identification expressed as a code.
    /// </summary>
    [IsoId("_Ri-zutp-Ed-ak6NoX_4Aeg_-142125379")]
    [DisplayName("Code")]
    public record Code : PersonIdentificationType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of person&apos;s identification.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PersonIdentificationType3Code Value { get; init; }
    }
}
