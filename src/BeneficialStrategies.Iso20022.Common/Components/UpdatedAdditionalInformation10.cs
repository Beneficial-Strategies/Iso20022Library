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
[IsoId("_c5pcHZKQEeWHWpTQn1FFVg")]
[DisplayName("Updated Additional Information")]
public partial record UpdatedAdditionalInformation10
{
    #nullable enable
    
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_c5pcIZKQEeWHWpTQn1FFVg")]
    [DisplayName("Update Description")]
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? UpdateDescription { get; init; } 
    
    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_c5pcI5KQEeWHWpTQn1FFVg")]
    [DisplayName("Update Date")]
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UpdateDate { get; init; } 
    
    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    [IsoId("_c5pcJZKQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINZMax8000Text)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    // ID for the above is _c5pcJZKQEeWHWpTQn1FFVg
    
    
    #nullable disable
    
}
