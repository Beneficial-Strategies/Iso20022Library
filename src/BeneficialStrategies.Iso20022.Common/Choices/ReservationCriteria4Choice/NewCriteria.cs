// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReservationCriteria4Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_gt_xE9cZEeqRFcf2R4bPBw")]
    [DisplayName("New Criteria")]
    public partial record NewCriteria : ReservationCriteria4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_gv7Ds9cZEeqRFcf2R4bPBw")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; } 
        
        /// <summary>
        /// Defines the criteria to extract the reservation information.
        /// </summary>
        [IsoId("_gv7DtdcZEeqRFcf2R4bPBw")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public ReservationSearchCriteria4? SearchCriteria { get; init; } 
        
        /// <summary>
        /// Defines the expected reservation report.
        /// </summary>
        [IsoId("_gv7Dt9cZEeqRFcf2R4bPBw")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public ReservationReturnCriteria1? ReturnCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}
