// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CRSStatus3Choice
{
    /// <summary>
    /// Common Reporting Standard (CRS) status expressed as a code.
    /// </summary>
    [IsoId("__Xcm0UNeEeamLdeYEZm56w")]
    [DisplayName("Code")]
    public record Code : CRSStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the Common Reporting Status (CRS) status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CRSStatus1Code Value { get; init; }
    }
}
