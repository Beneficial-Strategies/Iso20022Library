// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BeneficiaryCertificationType5Choice
{
    /// <summary>
    /// Standard code to specify the type of certification required.
    /// </summary>
    [IsoId("_Nqanm_mgEeCXPrLWfSEUvQ")]
    [DisplayName("Code")]
    public record Code : BeneficiaryCertificationType5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of certification required.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BeneficiaryCertificationType4Code Value { get; init; }
    }
}
