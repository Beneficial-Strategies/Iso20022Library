// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TEFRARules3Choice
{
    /// <summary>
    /// TEFRA rules expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_irPNceLcEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public record Code : TEFRARules3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the Tax Equity and Fiscal Responsibility Act (TEFRA) rule levied by the IRS under which the security is issued.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TEFRARules1Code Value { get; init; }
    }
}
