// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CurrencyCriteria1Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_705FR6MgEeCJ6YNENx4h-w_-1083355191")]
    [DisplayName("New Criteria")]
    public partial record NewCriteria : CurrencyCriteria1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_71C2QaMgEeCJ6YNENx4h-w_1369254414")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; } 
        
        /// <summary>
        /// Defines the criteria based on which the information is extracted.
        /// </summary>
        [IsoId("_71C2QqMgEeCJ6YNENx4h-w_-294471871")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public ValueList<CurrencySourceTarget1> SearchCriteria { get; init; } = [];
        // ID for the above is _71C2QqMgEeCJ6YNENx4h-w_-294471871
        
        
        #nullable disable
        
    }
}
