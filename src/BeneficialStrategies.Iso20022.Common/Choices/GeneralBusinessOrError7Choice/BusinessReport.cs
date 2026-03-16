// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessOrError7Choice
{
    /// <summary>
    /// Reports either on the business information or on a business error.
    /// </summary>
    [IsoId("_QdJoA3hdEeidzqjNEfehPg")]
    [DisplayName("Business Report")]
    public record BusinessReport : GeneralBusinessOrError7Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of a general business information system, as assigned by the system transaction administrator.
        /// </summary>
        [IsoId("_QrMrE3hdEeidzqjNEfehPg")]
        [DisplayName("Business Information Reference")]
        [IsoXmlTag("BizInfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text BusinessInformationReference { get; init; }

        /// <summary>
        /// Requested business information.
        /// </summary>
        [IsoId("_QrMrFXhdEeidzqjNEfehPg")]
        [DisplayName("General Business Or Error")]
        [IsoXmlTag("GnlBizOrErr")]
        public required GeneralBusinessOrError8Choice_ GeneralBusinessOrError { get; init; }
    }
}
