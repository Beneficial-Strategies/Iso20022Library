// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information for a notification advice.
/// </summary>
[IsoId("_RkLGgNp-Ed-ak6NoX_4Aeg_32536059")]
[DisplayName("Notification Processing Status")]
public partial record NotificationProcessingStatus1
{
    #nullable enable
    
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RkLGgdp-Ed-ak6NoX_4Aeg_364081629")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus1FormatChoice_ Status { get; init; } 
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkLGgtp-Ed-ak6NoX_4Aeg_364081652")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
