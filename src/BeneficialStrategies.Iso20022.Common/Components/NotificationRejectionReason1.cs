// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a notification advice.
/// </summary>
[IsoId("_RkLGhtp-Ed-ak6NoX_4Aeg_301280207")]
[DisplayName("Notification Rejection Reason")]
public partial record NotificationRejectionReason1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RkLGh9p-Ed-ak6NoX_4Aeg_403789574")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason6FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason6FormatChoice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RkLGh9p-Ed-ak6NoX_4Aeg_403789574
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkLGiNp-Ed-ak6NoX_4Aeg_403789575")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
