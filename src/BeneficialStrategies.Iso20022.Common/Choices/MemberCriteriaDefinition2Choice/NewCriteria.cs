// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberCriteriaDefinition2Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_iwxEc3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("New Criteria")]
    [IsoXmlTag("NewCrit")]
    public record NewCriteria : MemberCriteriaDefinition2Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_i_D_I3SbEeiH1ZOt2UD8vQ")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria based on which the information is extracted.
        /// </summary>
        [IsoId("_i_D_JXSbEeiH1ZOt2UD8vQ")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public MemberSearchCriteria4? SearchCriteria { get; init; }

        /// <summary>
        /// Defines the expected report.
        /// </summary>
        [IsoId("_i_D_J3SbEeiH1ZOt2UD8vQ")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public MemberReturnCriteria1? ReturnCriteria { get; init; }
    }
}
