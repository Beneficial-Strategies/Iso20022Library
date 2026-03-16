// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the reservation information and the expected reservation report. A name may be given to the new query.
/// </summary>
[IsoId("_xpxD1Qy_Ee2Wmf2RrXviyA")]
[DisplayName("Reservation Criteria")]
public record ReservationCriteria6
{
    /// <summary>
    /// Name of the query defined by the search criteria and return criteria.
    /// </summary>
    [IsoId("_xzyigwy_Ee2Wmf2RrXviyA")]
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NewQueryName { get; init; }

    /// <summary>
    /// Defines the criteria to extract the reservation information.
    /// </summary>
    [IsoId("_xzyihQy_Ee2Wmf2RrXviyA")]
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ReservationSearchCriteria5? SearchCriteria { get; init; }

    /// <summary>
    /// Defines the expected reservation report.
    /// </summary>
    [IsoId("_xzyihwy_Ee2Wmf2RrXviyA")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public ReservationReturnCriteria1? ReturnCriteria { get; init; }
}
