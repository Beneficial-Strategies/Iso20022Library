// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertificationTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the certification format required, that is, physical or electronic format.
    /// </summary>
    [IsoId("_Q3BFmNp-Ed-ak6NoX_4Aeg_-801680904")]
    [DisplayName("Code")]
    public record Code : CertificationTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the certification format required, that is, physical or electronic format.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CertificationFormatType1Code Value { get; init; }
    }
}
