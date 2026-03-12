// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralValueCriteriaDefinition1Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_jJp0oO5NEeCisYr99QEiWA_-1239939936")]
    [DisplayName("New Criteria")]
    public partial record NewCriteria : CollateralValueCriteriaDefinition1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_jJp0ou5NEeCisYr99QEiWA_-275893458")]
        [DisplayName("Query Name")]
        [IsoXmlTag("QryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? QueryName { get; init; } 
        
        /// <summary>
        /// Defines the criteria to be used to extract the account information.
        /// </summary>
        [IsoId("_jJp0o-5NEeCisYr99QEiWA_-1182011055")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public CollateralValueSearchCriteria1? SearchCriteria { get; init; } 
        
        /// <summary>
        /// Defines the expected account report.
        /// </summary>
        [IsoId("_jJp0pO5NEeCisYr99QEiWA_-1499787716")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public CashAccountReturnCriteria2? ReturnCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}
