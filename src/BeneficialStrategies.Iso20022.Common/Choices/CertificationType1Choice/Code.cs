// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertificationType1Choice
{
    /// <summary>
    /// Certificate type expressed as a code.
    /// </summary>
    [IsoId("_r9G_cBdEEeK5g-3oYI0_9Q")]
    [DisplayName("Code")]
    public record Code : CertificationType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of certificate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CertificateType2Code Value { get; init; }
    }
}
