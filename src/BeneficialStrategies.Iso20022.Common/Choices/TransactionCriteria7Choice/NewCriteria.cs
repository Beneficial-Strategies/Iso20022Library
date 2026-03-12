// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionCriteria7Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_-S2D0wKxEe2rHs6fbn9-0A")]
    [DisplayName("New Criteria")]
    public partial record NewCriteria : TransactionCriteria7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_-9kb0wKxEe2rHs6fbn9-0A")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; } 
        
        /// <summary>
        /// Defines the criteria on which the information is extracted.
        /// </summary>
        [IsoId("_-9kb1QKxEe2rHs6fbn9-0A")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public TransactionSearchCriteria10? SearchCriteria { get; init; } 
        
        /// <summary>
        /// Indicates the format of the requested report.
        /// </summary>
        [IsoId("_-9kb1wKxEe2rHs6fbn9-0A")]
        [DisplayName("Statement Report")]
        [IsoXmlTag("StmtRpt")]
        public ReportIndicator1Code? StatementReport { get; init; } 
        
        /// <summary>
        /// Defines the expected payment transaction report.
        /// </summary>
        [IsoId("_-9kb2QKxEe2rHs6fbn9-0A")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public TransactionReturnCriteria5? ReturnCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}
