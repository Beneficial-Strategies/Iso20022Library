// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identify the original notification and to provide the status.
/// </summary>
[IsoId("_1E2M0Bf2Ed--ta5221d4PQ")]
[DisplayName("Original Notification")]
public partial record OriginalNotification3
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    [IsoId("_1FcpwRf2Ed--ta5221d4PQ")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_1FlzsRf2Ed--ta5221d4PQ")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    [IsoId("_1Fvkshf2Ed--ta5221d4PQ")]
    [DisplayName("Original Notification Identification")]
    [IsoXmlTag("OrgnlNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    [IsoId("_1GVakxf2Ed--ta5221d4PQ")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public NotificationStatus3Code? NotificationStatus { get; init; } 
    
    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    [IsoId("_1GyGgRf2Ed--ta5221d4PQ")]
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalStatusInformation { get; init; } 
    
    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    [IsoId("_1HFoghf2Ed--ta5221d4PQ")]
    [DisplayName("Original Notification Reference")]
    [IsoXmlTag("OrgnlNtfctnRef")]
    public OriginalNotificationReference2? OriginalNotificationReference { get; init; } 
    
    
    #nullable disable
    
}
