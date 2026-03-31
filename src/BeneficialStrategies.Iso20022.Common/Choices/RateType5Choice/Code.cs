// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType5Choice
{
    /// <summary>
    /// Rate expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Quh39dp-Ed-ak6NoX_4Aeg_882991172")]
    [DisplayName("Code")]
    public record Code : RateType5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the rate is fixed or variable or a forfeit.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RateType1Code Value { get; init; }
    }
}
