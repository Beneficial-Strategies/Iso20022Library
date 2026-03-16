// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationCriteria3Choice
{
    /// <summary>
    /// Defines the criteria based on which the information is extracted.
    /// </summary>
    [IsoId("_EBPJRW4-EeiU9cctagi5ow")]
    [DisplayName("New Criteria")]
    [IsoXmlTag("NewCrit")]
    public record NewCriteria : ReservationCriteria3Choice_
    {
        /// <summary>
        /// Name of the query defined by the search criteria and return criteria.
        /// </summary>
        [IsoId("_ELOLtW4-EeiU9cctagi5ow")]
        [DisplayName("New Query Name")]
        [IsoXmlTag("NewQryNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NewQueryName { get; init; }

        /// <summary>
        /// Defines the criteria to extract the reservation information.
        /// </summary>
        [IsoId("_ELOLt24-EeiU9cctagi5ow")]
        [DisplayName("Search Criteria")]
        [IsoXmlTag("SchCrit")]
        public ReservationSearchCriteria3? SearchCriteria { get; init; }

        /// <summary>
        /// Defines the expected reservation report.
        /// </summary>
        [IsoId("_ELOLuW4-EeiU9cctagi5ow")]
        [DisplayName("Return Criteria")]
        [IsoXmlTag("RtrCrit")]
        public ReservationReturnCriteria1? ReturnCriteria { get; init; }
    }
}
