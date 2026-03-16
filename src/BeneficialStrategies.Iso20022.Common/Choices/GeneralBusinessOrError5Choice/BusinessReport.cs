// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessOrError5Choice
{
    /// <summary>
    /// Reports either on the business information or on a business error.
    /// </summary>
    [IsoId("_MP5s45lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Report")]
    [IsoXmlTag("BizRpt")]
    public record BusinessReport : GeneralBusinessOrError5Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of a general business information system, as assigned by the system transaction administrator.
        /// </summary>
        [IsoId("_MYGmo5lgEeeE1Ya-LgRsuQ")]
        [DisplayName("Business Information Reference")]
        [IsoXmlTag("BizInfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text BusinessInformationReference { get; init; }

        /// <summary>
        /// Requested business information.
        /// </summary>
        [IsoId("_MYGmpZlgEeeE1Ya-LgRsuQ")]
        [DisplayName("General Business Or Error")]
        [IsoXmlTag("GnlBizOrErr")]
        public required GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; init; }
    }
}
