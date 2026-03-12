// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralValueCriteriaDefinition2Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_zewXo-FgEeWIA4E9cYSxxQ")]
    [DisplayName("New Criteria")]
    public partial record NewCriteria : CollateralValueCriteriaDefinition2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_zn-lEeFgEeWIA4E9cYSxxQ")]
        [DisplayName("Query Name")]
        [IsoXmlTag("QryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? QueryName { get; init; } 
        
        /// <summary>
        /// Defines the criteria to be used to extract the account information.
        /// </summary>
        [IsoId("_zn-lE-FgEeWIA4E9cYSxxQ")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public CollateralValueSearchCriteria2? SearchCriteria { get; init; } 
        
        /// <summary>
        /// Defines the expected account report.
        /// </summary>
        [IsoId("_zn-lFeFgEeWIA4E9cYSxxQ")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public CashAccountReturnCriteria2? ReturnCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}
