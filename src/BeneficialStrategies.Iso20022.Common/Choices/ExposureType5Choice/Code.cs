// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExposureType5Choice
{
    /// <summary>
    /// Collateral movement exposure type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_gBPhM_IxEd-dOvqmSLSz5g")]
    [DisplayName("Code")]
    public record Code : ExposureType5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying business area/type of trade causing the collateral movement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExposureType2Code Value { get; init; }
    }
}
