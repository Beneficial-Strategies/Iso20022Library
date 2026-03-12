// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information with update description and date.
/// </summary>
[IsoId("_XWm_Ntp-Ed-ak6NoX_4Aeg_-831316652")]
[DisplayName("Updated Additional Information")]
public partial record UpdatedAdditionalInformation6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_XWm_N9p-Ed-ak6NoX_4Aeg_1583345004")]
    [DisplayName("Update Description")]
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? UpdateDescription { get; init; } 
    
    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_XWm_ONp-Ed-ak6NoX_4Aeg_472433585")]
    [DisplayName("Update Date")]
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UpdateDate { get; init; } 
    
    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    [IsoId("_XWm_Odp-Ed-ak6NoX_4Aeg_-1407872055")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax350Text AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
