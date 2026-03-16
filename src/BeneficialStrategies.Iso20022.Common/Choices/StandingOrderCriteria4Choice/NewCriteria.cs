// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderCriteria4Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_gdi6Q9cZEeqRFcf2R4bPBw")]
    [DisplayName("New Criteria")]
    public record NewCriteria : StandingOrderCriteria4Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_ge92k9cZEeqRFcf2R4bPBw")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria to be used to extract the standing order information.
        /// </summary>
        [IsoId("_ge92ldcZEeqRFcf2R4bPBw")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public StandingOrderSearchCriteria4? SearchCriteria { get; init; }

        /// <summary>
        /// Defines the expected standing order report.
        /// </summary>
        [IsoId("_ge92l9cZEeqRFcf2R4bPBw")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public StandingOrderReturnCriteria1? ReturnCriteria { get; init; }
    }
}
