// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification and to provide the status.
/// </summary>
[IsoId("_b49UwdcZEeqRFcf2R4bPBw")]
[DisplayName("Original Notification")]
public partial record OriginalNotification13
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("_b6SxgdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_b6Sxg9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("_b6SxhdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    [IsoId("_b6Sxh9cZEeqRFcf2R4bPBw")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public NotificationStatus3Code? NotificationStatus { get; init; } 
    
    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    [IsoId("_b6SxidcZEeqRFcf2R4bPBw")]
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalStatusInformation { get; init; } 
    
    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    [IsoId("_b6Sxi9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public OriginalNotificationReference11? OriginalNotificationReference { get; init; } 
    
    
    #nullable disable
    
}
