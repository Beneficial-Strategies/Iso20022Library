// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountCriteria2Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_4GLX1ZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("New Criteria")]
    [IsoXmlTag("NewCrit")]
    public record NewCriteria : AccountCriteria2Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_4OF9s5laEeeE1Ya-LgRsuQ")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria to be used to extract the account information.
        /// </summary>
        [IsoId("_4OF9tZlaEeeE1Ya-LgRsuQ")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public CashAccountSearchCriteria6? SearchCriteria { get; init; }

        /// <summary>
        /// Defines the expected account report.
        /// </summary>
        [IsoId("_4OF9t5laEeeE1Ya-LgRsuQ")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public CashAccountReturnCriteria4? ReturnCriteria { get; init; }
    }
}
