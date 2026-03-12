// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Undertaking extend or pay query details.
/// </summary>
[IsoId("_-Dxn0nltEeG7BsjMvd1mEw_1814093000")]
[DisplayName("Extend Or Pay Query")]
public partial record ExtendOrPayQuery2
{
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Dxn03ltEeG7BsjMvd1mEw_1205315845")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking9 UndertakingIdentification { get; init; } 
    
    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-Dxn1HltEeG7BsjMvd1mEw_812048330")]
    [DisplayName("Demand Details")]
    [IsoXmlTag("DmndDtls")]
    public required Demand4 DemandDetails { get; init; } 
    
    /// <summary>
    /// Processing status reported by the applicant.
    /// </summary>
    [IsoId("_-Dxn1XltEeG7BsjMvd1mEw_-1345817899")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required DemandStatus1Code Status { get; init; } 
    
    
    #nullable disable
    
}
