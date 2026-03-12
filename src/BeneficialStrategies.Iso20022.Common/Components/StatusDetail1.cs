// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the status.
/// </summary>
[IsoId("_VPaCAPH9Eeaz_YGUGLjP6A")]
[DisplayName("Status Detail")]
public partial record StatusDetail1
{
    #nullable enable
    
    /// <summary>
    /// Country of the institution relevant for the decision.
    /// </summary>
    [IsoId("_MvO2kD7yEee5faD4glTPKA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Details of the institution which is relevant for the decision.
    /// </summary>
    [IsoId("_J71NQfIDEeaz_YGUGLjP6A")]
    [DisplayName("Competent Authority")]
    [IsoXmlTag("CmptntAuthrty")]
    public required SupervisingAuthorityIdentification1 CompetentAuthority { get; init; } 
    
    /// <summary>
    /// Code indicating the status following the decision.
    /// </summary>
    [IsoId("_g_8Q0fH9Eeaz_YGUGLjP6A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public IsoMax10Text? Status { get; init; } 
    
    /// <summary>
    /// Code indicating the reason of the decision.
    /// </summary>
    [IsoId("_YID0sfH-Eeaz_YGUGLjP6A")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public required IsoMax10Text StatusReason { get; init; } 
    
    /// <summary>
    /// Period of time when the decision is effective.
    /// </summary>
    [IsoId("_tG_sgTb5Eeer2ugaDqMdXg")]
    [DisplayName("Activity Period")]
    [IsoXmlTag("ActvtyPrd")]
    public Period4Choice_? ActivityPeriod { get; init; } 
    
    /// <summary>
    /// Any other additional information about the decision.
    /// </summary>
    [IsoId("_uUdG8En5EeexwKvkdw4OGA")]
    [DisplayName("Comment")]
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public IsoMax20000Text? Comment { get; init; } 
    
    
    #nullable disable
    
}
