// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BusinessDayCriteria3Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_yFXaBZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("New Criteria")]
    [IsoXmlTag("NewCrit")]
    public record NewCriteria : BusinessDayCriteria3Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_yNYGg5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria on which the information is extracted.
        /// </summary>
        [IsoId("_yNYGhZlcEeeE1Ya-LgRsuQ")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public BusinessDaySearchCriteria2? SearchCriteria { get; init; }

        /// <summary>
        /// Defines the expected report.
        /// </summary>
        [IsoId("_yNYGh5lcEeeE1Ya-LgRsuQ")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public BusinessDayReturnCriteria2? ReturnCriteria { get; init; }
    }
}
