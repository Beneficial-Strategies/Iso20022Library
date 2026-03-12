// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderCriteria2Choice
{
    /// <summary>
    /// Explicitly defines the query criteria.
    /// </summary>
    [IsoId("_i8ykQ5lPEee-Zps0fZQaFQ")]
    [DisplayName("New Criteria")]
    public partial record NewCriteria : StandingOrderCriteria2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_jE-P45lPEee-Zps0fZQaFQ")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; } 
        
        /// <summary>
        /// Defines the criteria to be used to extract the standing order information.
        /// </summary>
        [IsoId("_jE-P5ZlPEee-Zps0fZQaFQ")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public StandingOrderSearchCriteria2? SearchCriteria { get; init; } 
        
        /// <summary>
        /// Defines the expected standing order report.
        /// </summary>
        [IsoId("_jE-P55lPEee-Zps0fZQaFQ")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public StandingOrderReturnCriteria1? ReturnCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}
