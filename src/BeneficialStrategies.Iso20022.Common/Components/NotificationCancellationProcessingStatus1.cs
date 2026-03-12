// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information for a notification cancellation request.
/// </summary>
[IsoId("_RkBVhtp-Ed-ak6NoX_4Aeg_708552720")]
[DisplayName("Notification Cancellation Processing Status")]
public partial record NotificationCancellationProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RkBVh9p-Ed-ak6NoX_4Aeg_818452581")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus2FormatChoice_ Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkBViNp-Ed-ak6NoX_4Aeg_818452582")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
