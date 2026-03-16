// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError5Choice
{
    /// <summary>
    /// Reports either on the standing order or on a business error.
    /// </summary>
    [IsoId("_COWPUW4-EeiU9cctagi5ow")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public record Report : StandingOrderOrError5Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_CZ-QgW4-EeiU9cctagi5ow")]
        [DisplayName("Standing Order Identification")]
        [IsoXmlTag("StgOrdrId")]
        public required StandingOrderIdentification4 StandingOrderIdentification { get; init; }

        /// <summary>
        /// Requested information on the standing order or business error when information has not been found.
        /// </summary>
        [IsoId("_CZ-Qg24-EeiU9cctagi5ow")]
        [DisplayName("Standing Order Or Error")]
        [IsoXmlTag("StgOrdrOrErr")]
        public required StandingOrderOrError6Choice_ StandingOrderOrError { get; init; }
    }
}
