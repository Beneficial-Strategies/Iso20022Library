// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitCriteria5Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_PoO3dZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("New Criteria")]
    public record NewCriteria : LimitCriteria5Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_PwPj95lcEeeE1Ya-LgRsuQ")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria to extract the limit information.
        /// </summary>
        [IsoId("_PwPj-ZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public LimitSearchCriteria5? SearchCriteria { get; init; }

        /// <summary>
        /// Defines the expected limit report.
        /// </summary>
        [IsoId("_PwPj-5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public LimitReturnCriteria2? ReturnCriteria { get; init; }
    }
}
