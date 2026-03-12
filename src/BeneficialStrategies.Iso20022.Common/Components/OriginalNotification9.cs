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
[IsoId("_0u0rCTq4EeWZFYSPlduMhw")]
[DisplayName("Original Notification")]
public partial record OriginalNotification9
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("_03Nx4zq4EeWZFYSPlduMhw")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_03Nx5Tq4EeWZFYSPlduMhw")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("_03Nx5zq4EeWZFYSPlduMhw")]
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    [IsoId("_03Nx6Tq4EeWZFYSPlduMhw")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public NotificationStatus3Code? NotificationStatus { get; init; } 
    
    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    [IsoId("_03Nx6zq4EeWZFYSPlduMhw")]
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalStatusInformation { get; init; } 
    
    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    [IsoId("_03Nx7Tq4EeWZFYSPlduMhw")]
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public OriginalNotificationReference7? OriginalNotificationReference { get; init; } 
    
    
    #nullable disable
    
}
