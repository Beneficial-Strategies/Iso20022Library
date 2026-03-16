// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StampDutyType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the stamp duty information.
    /// </summary>
    [IsoId("_Ro8Rx9p-Ed-ak6NoX_4Aeg_-874099083")]
    [DisplayName("Code")]
    public record Code : StampDutyType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if the stamp duty is applicable.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StampDutyType1Code Value { get; init; }
    }
}
