// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LimitCriteria6Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_FMyWZW4-EeiU9cctagi5ow")]
    [DisplayName("New Criteria")]
    public partial record NewCriteria : LimitCriteria6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_FZ5lV24-EeiU9cctagi5ow")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; } 
        
        /// <summary>
        /// Defines the criteria to extract the limit information.
        /// </summary>
        [IsoId("_FZ5lWW4-EeiU9cctagi5ow")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public LimitSearchCriteria6? SearchCriteria { get; init; } 
        
        /// <summary>
        /// Defines the expected limit report.
        /// </summary>
        [IsoId("_FZ5lW24-EeiU9cctagi5ow")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public LimitReturnCriteria2? ReturnCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}
