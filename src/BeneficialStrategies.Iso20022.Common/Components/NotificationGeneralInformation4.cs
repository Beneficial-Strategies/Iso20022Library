// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event notification type and status.
/// </summary>
[IsoId("_P0SfATT_Ee2tRf29bleifQ")]
[DisplayName("Notification General Information")]
public partial record NotificationGeneralInformation4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the group of meeting notification messages when the notification is split in multiple (paginated) messages.
    /// </summary>
    [IsoId("_baXxUDT_Ee2tRf29bleifQ")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Type of notification.
    /// </summary>
    [IsoId("_QLihYTT_Ee2tRf29bleifQ")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required NotificationType3Code NotificationType { get; init; } 
    
    /// <summary>
    /// Status of the details of the event.
    /// </summary>
    [IsoId("_QLihaTT_Ee2tRf29bleifQ")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public required EventStatus1 NotificationStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_QLihcTT_Ee2tRf29bleifQ")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether a specific confirmation of holding together with a participation and/or vote instruction is required by the issuer (for instance as required in the German Stock Corporation Act paragraph 67c section 3).
    /// </summary>
    [IsoId("_QLihczT_Ee2tRf29bleifQ")]
    [DisplayName("Confirmation Of Holding Required")]
    [IsoXmlTag("ConfOfHldgReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ConfirmationOfHoldingRequired { get; init; } 
    
    
    #nullable disable
    
}
