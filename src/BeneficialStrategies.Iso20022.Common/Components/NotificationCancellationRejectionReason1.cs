// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a notification cancellation request.
/// </summary>
[IsoId("_RkLGg9p-Ed-ak6NoX_4Aeg_881251146")]
[DisplayName("Notification Cancellation Rejection Reason")]
public partial record NotificationCancellationRejectionReason1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RkLGhNp-Ed-ak6NoX_4Aeg_1166618034")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason11FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason11FormatChoice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RkLGhNp-Ed-ak6NoX_4Aeg_1166618034
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkLGhdp-Ed-ak6NoX_4Aeg_1166618064")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
