// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BeneficiaryCertificationType1Choice
{
    /// <summary>
    /// Standard code to specify the type of certification required.
    /// </summary>
    [IsoId("_Q0CqFtp-Ed-ak6NoX_4Aeg_-41633414")]
    [DisplayName("Code")]
    public record Code : BeneficiaryCertificationType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of certification required.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BeneficiaryCertificationType2Code Value { get; init; }
    }
}
