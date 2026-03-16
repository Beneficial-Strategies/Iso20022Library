// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertificationTypeFormat3Choice
{
    /// <summary>
    /// Standard code to specify the certification format required, that is, physical or electronic format.
    /// </summary>
    [IsoId("_bmuOoUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : CertificationTypeFormat3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the certification format required, that is, physical or electronic format.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CertificationFormatType1Code Value { get; init; }
    }
}
