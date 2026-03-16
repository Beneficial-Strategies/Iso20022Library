// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError7Choice
{
    /// <summary>
    /// Reports either on the standing order or on a business error.
    /// </summary>
    [IsoId("_eamLEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Report")]
    public record Report : StandingOrderOrError7Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_eb5yodcZEeqRFcf2R4bPBw")]
        [DisplayName("Standing Order Identification")]
        [IsoXmlTag("StgOrdrId")]
        public required StandingOrderIdentification6 StandingOrderIdentification { get; init; }

        /// <summary>
        /// Requested information on the standing order or business error when information has not been found.
        /// </summary>
        [IsoId("_eb5yo9cZEeqRFcf2R4bPBw")]
        [DisplayName("Standing Order Or Error")]
        [IsoXmlTag("StgOrdrOrErr")]
        public required StandingOrderOrError8Choice_ StandingOrderOrError { get; init; }
    }
}
