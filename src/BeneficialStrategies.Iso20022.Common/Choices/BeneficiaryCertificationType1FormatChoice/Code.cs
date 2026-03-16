// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BeneficiaryCertificationType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of beneficiary&apos;s certification.
    /// </summary>
    [IsoId("_RlqUSNp-Ed-ak6NoX_4Aeg_1012264214")]
    [DisplayName("Code")]
    public record Code : BeneficiaryCertificationType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of beneficiary&apos;s certification.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BeneficiaryCertificationType1Code Value { get; init; }
    }
}
