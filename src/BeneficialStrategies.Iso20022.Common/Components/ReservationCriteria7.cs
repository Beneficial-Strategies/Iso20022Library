// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reservation Criteria7.
/// </summary>
[IsoId("_zu8pFTEyEe6g-ffJsqGiSA")]
[DisplayName("Reservation Criteria7")]
public partial record ReservationCriteria7
{
    #nullable enable

    /// <summary>
    /// New Query Name.
    /// </summary>
    [DisplayName("New Query Name")]
    [IsoXmlTag("NewQryNm")]
    public IsoMax35Text? NewQueryName { get; init; } 

    /// <summary>
    /// Return Criteria.
    /// </summary>
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public ReservationReturnCriteria1? ReturnCriteria { get; init; } 

    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public ValueList<ReservationSearchCriteria6> SearchCriteria { get; init; } = [];

    
    #nullable disable
    
}
