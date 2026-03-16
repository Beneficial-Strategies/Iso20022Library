// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneralBusinessInformationCriteriaDefinition1Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_1dxAk5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("New Criteria")]
    [IsoXmlTag("NewCrit")]
    public record NewCriteria : GeneralBusinessInformationCriteriaDefinition1Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_1mEoA5lZEeeE1Ya-LgRsuQ")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria based on which the information is extracted.
        /// </summary>
        [IsoId("_1mEoBZlZEeeE1Ya-LgRsuQ")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public GeneralBusinessInformationSearchCriteria1? SearchCriteria { get; init; }

        /// <summary>
        /// Defines the expected report.
        /// </summary>
        [IsoId("_1mEoB5lZEeeE1Ya-LgRsuQ")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public GeneralBusinessInformationReturnCriteria1? ReturnCriteria { get; init; }
    }
}
