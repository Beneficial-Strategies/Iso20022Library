// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCriteria5Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_OkkalW49EeiU9cctagi5ow")]
    [DisplayName("New Criteria")]
    [IsoXmlTag("NewCrit")]
    public record NewCriteria : TransactionCriteria5Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_O2c0xW49EeiU9cctagi5ow")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria on which the information is extracted.
        /// </summary>
        [IsoId("_O2c0x249EeiU9cctagi5ow")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public TransactionSearchCriteria8? SearchCriteria { get; init; }

        /// <summary>
        /// Indicates the format of the requested report.
        /// </summary>
        [IsoId("_O2c0yW49EeiU9cctagi5ow")]
        [DisplayName("Statement Report")]
        [IsoXmlTag("StmtRpt")]
        public ReportIndicator1Code? StatementReport { get; init; }

        /// <summary>
        /// Defines the expected payment transaction report.
        /// </summary>
        [IsoId("_O2c0y249EeiU9cctagi5ow")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public TransactionReturnCriteria5? ReturnCriteria { get; init; }
    }
}
